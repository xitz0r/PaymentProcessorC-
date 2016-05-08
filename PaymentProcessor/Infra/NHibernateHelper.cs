using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessor.Infra
{
    public class NHibernateHelper
    {
        private static ISessionFactory fabric = NHibernateHelper.CreateSessionFactory();


        public static Configuration RecoverConfiguration()
        {
            Configuration cfg = new Configuration();
            cfg.Configure();
            return cfg;
        }

        public static void GenerateSchema()
        {
            Configuration cfg = RecoverConfiguration();
            new SchemaExport(cfg).Create(true, true);
        }

        public static ISession OpenSession()
        {
            return fabric.OpenSession();
        }

        private static ISessionFactory CreateSessionFactory()
        {
            Configuration cfg = NHibernateHelper.RecoverConfiguration();
            return cfg.BuildSessionFactory();
        }
    }
}
