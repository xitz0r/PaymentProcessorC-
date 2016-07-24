using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessor.Entities
{
    public class Card
    {
        public virtual int Id { get; set; }
        public virtual string PAN { get; set; }
        public virtual string Track1 { get; set; }
        public virtual string Track2 { get; set; }
        public virtual DateTime ExpirationDate { get; set; }
        public virtual int CVV2 { get; set; }
        public virtual Boolean Blocked { get; set; }
        public virtual Student Student { get; set; }

        private string PANTrack1, PANTrack2;
        private string expirationDateTrack1, expirationDateTrack2;
        private static char sentinel= '¨';

        public Card() { }

        public Card(string trackData, int cvv2)
        {
            this.FillTrackData(trackData);
            this.CVV2 = cvv2;
          
        }

        private void FillTrackData(string trackdata)
        {
            string[] trackList = trackdata.Split('\r');
            foreach (var track in trackList)
            {
                if (track.Split('^').Length == 3)       //track 1
                {
                    this.ReadTrack1(track);
                    this.Track1 = track;
                }
                else if (track.Split('=').Length == 2)  //track 2
                { 
                    this.ReadTrack2(track);
                    this.Track2 = track;
                }
                //else
                    //track 3
            }

            CheckAndFillTracks();
        }

        private void ReadTrack1(string track)
        {
            if (string.IsNullOrEmpty(track))
                return;


            int i = 0;
            this.PANTrack1 = "";


            while (i < track.Length && !char.IsDigit(track[i])) //jumping over track 1 flags [%b]
                i++;


            while (i < track.Length && char.IsDigit(track[i]))  //reading PAN until flag [^]
                this.PANTrack1 += track[i++];
            i++;    //jumping first over [¨]


            while (i < track.Length && track[i] != sentinel)  //reading cardholder name until second flag [^]
                i++;    //TODO create a field in the database and class for the cardholder name
            i++;    //jumping over second [¨]


            this.expirationDateTrack1 = track.Substring(i, 4);
            i += 4;

            //TODO read service code


            //TODO read rest of track 1 until last flag [?]

        }

        private void ReadTrack2(string track)
        {
            if (string.IsNullOrEmpty(track))
                return;

            track = track.Replace(";", String.Empty);
            track = track.Replace("ç", String.Empty);

            this.PANTrack2 = track.Split('=')[0];
            this.expirationDateTrack2 = track.Split('=')[1].Substring(0, 4);
            //TODO read service code
            //TODO read rest of track 2
        }

        private void CheckAndFillTracks()
        {
            if (String.IsNullOrEmpty(this.Track1) && String.IsNullOrEmpty(this.Track2))
                throw new Exception("Both tracks are empty");
            else if (!String.IsNullOrEmpty(this.Track1) && !String.IsNullOrEmpty(this.Track2))
            {
                if (this.PANTrack1 != this.PANTrack2)
                    throw new Exception("PAN in track 1 doesn't match with PAN in track 2");
                else if (this.expirationDateTrack1 != this.expirationDateTrack2)
                    throw new Exception("Expiration date in track 1 doesn't match with expiration date in track 2");
            }

            string pan = (String.IsNullOrEmpty(this.PANTrack1) ? this.PANTrack2 : this.PANTrack1);
            foreach (char c in pan)
                if (!Char.IsDigit(c))
                    throw new Exception("Invalid PAN, no letters are allowed");


            int year, month;

            //card validated at this point

            if (!String.IsNullOrEmpty(this.Track2))
            {
                this.PAN = this.PANTrack2;
                year = 2000 + Int32.Parse(this.expirationDateTrack2.Substring(0, 2));
                month = Int32.Parse(this.expirationDateTrack2.Substring(2, 2));
            }
            else
            {
                this.PAN = this.PANTrack1;
                year = 2000 + Int32.Parse(this.expirationDateTrack1.Substring(0, 2));
                month = Int32.Parse(this.expirationDateTrack1.Substring(2, 2));
            }

            this.ExpirationDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));
        }
    }
}
