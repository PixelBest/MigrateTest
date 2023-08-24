using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lims.Models;
using System.Collections.ObjectModel;

namespace Excel
{
    public class ApplicationContext : DbContext
    {
        public DbSet<msg> msg { get; set; }
        public DbSet<DocumentRouteStepT> DocumentRouteStepT { get; set; }
        public DbSet<TestOrderLineT> TestOrderLineT { get; set; }
        public DbSet<Desc> Desc { get; set; }
        public DbSet<BaseGuid> BaseGuid { get; set; }
        public DbSet<Sample> Sample { get; set; }
        public DbSet<TestOrder> TestOrder { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Excel;Username=postgres;Password=123123");
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
    }
    [Table("BaseGuid")]
    public class BaseGuid
    {
        [Key]
        public int Id { get; set; }
        [Column("Guid")]
        public string? Guid { get; set; }
        [Column("DESCRIPTION_TYPE_ID")]
        public int? DESCRIPTION_TYPE_ID { get; set; }
        [Column("CODE")]
        public int? CODE { get; set; }
        [Column("SHORT_NAME")]
        public string? SHORT_NAME { get; set; }
        [Column("NAME")]
        public string? NAME { get; set; }
        [Column("BEGIN_DATE")]
        public string? BEGIN_DATE { get; set; }
        [Column("END_DATE")]
        public string? END_DATE { get; set; } 
        [Column("NOTE")]
        public string? NOTE { get; set; }
        [Column("SHORT_TEST_TYPE")]
        public string? SHORT_TEST_TYPE { get; set; }
    }
    public class TestOrder
    {
        public int Id { get; set; }
        public string NumProtocol { get; set; }
        public DateTime DocumentDate { get; set; }
        public string? Type { get; set; }
        public string? Plavka { get; set; }
        public string? Consignment { get; set; }
        public float D { get; set; }
        public float S { get; set; }
        public string? Standart { get; set; }
        public string? Grade { get; set; }
        public string? StrenghtGroup { get; set; }
        public string? Laboratory { get; set; }
        public string? Status { get; set; }
        public string? Number { get; set; }

        public ObservableCollection<Sample> Samples { get; set; }

    }

    public class Sample
    {
        public int Id { get; set; }
        public int TestOrderId { get; set; }
        public string? SampleNum { get; set; }
        public string? Result { get; set; }
        public string? TestType { get; set; }
        public string? TestShortType { get; set; }
        public string? EI { get; set; }
        public string? Temperature { get; set; }
        public string? Hardness { get; set; }
        public string? Note { get; set; }
        public string? SampleType { get; set; }
        public string? Value { get; set; }
        public bool? T_O { get; set; }
        public bool? TestCode { get; set; }
        public byte[]? QR { get; set; }
        public string? Status { get; set; }
    }
}
