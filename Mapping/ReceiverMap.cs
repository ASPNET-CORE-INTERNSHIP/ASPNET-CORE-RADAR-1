﻿using ASPNETAOP.Models;
using FluentNHibernate.Mapping;
using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETAOP.Mapping
{
    public class ReceiverMap : ClassMapping<Receiver>
    {
        public ReceiverMap()
        {
            Id(x => x.ID, x =>
            {
                x.Generator(Generators.Guid);
                x.Type(NHibernateUtil.Guid);
                x.Column("ID");
                x.UnsavedValue(Guid.Empty);
            });

            Property(b => b.name, x =>
            {
                x.Length(500);
                x.Type(NHibernateUtil.StringClob);
                x.NotNullable(false);
            });

            Property(b => b.listening_time, x =>
            {
                x.Type(NHibernateUtil.Double);
            });

            Property(b => b.rest_time, x =>
            {
                x.Type(NHibernateUtil.Double);
            });

            Property(b => b.recovery_time, x =>
            {
                x.Type(NHibernateUtil.Double);
            });
            /*
    //or use this mapping 
              public class ReceiverMap: ClassMap < Receiver > { 
                public ReceiverMap() {   
                    Table("Receiver");
                    Id(x => x.ID);  
                    Map(x => x.name);  
                    Map(x => x.listening_time);  
                    Map(x => x.rest_time);  
                    Map(x => x.recovery_time);  
                    //References(x => x.Radar).Column("ReceiverId").Not.Nullable();
                }  
            }
             */

            Table("Receiver");
        }
    }
}
