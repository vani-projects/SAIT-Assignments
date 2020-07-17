using System;
using CPRG214.Vani.AssetTracker.Domain;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// Create the dbcontext class,run the add-migration command and provide the name CreateAssetsTracker.This creates a class with 
/// up() and down() methods
/// and run update-databse to create database.
/// set data project as starter project
/// </summary>

namespace CPRG214.Vani.AssetTracker.Data
{
    public class AssetContext:DbContext
    {
        public AssetContext() : base(){ } //constructor

        //dbset collection properties for 2 entities using pluralised names as a programming convention
        public DbSet<Asset> Assets { get; set; }

        public DbSet<AssetType> AssetTypes { get; set; }

        //onconfiguring is protected overide method from base class used for configuirng connectionstring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Change the connection string here for your home computer/lab computer
            optionsBuilder.UseSqlServer(@"Server=localhost\sqlexpress;
                                            Database=AssetsTracker;
                                    Trusted_Connection=True;");
        }


        //create/build model database for the context (i.e) AssetsTracker db two entities assettype and asset
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed data created here for AssetType table
            //lookup table
            modelBuilder.Entity<AssetType>().HasData(
                new AssetType { Id = 1,Name = "Computer"},
                new AssetType { Id = 2, Name ="Monitors"},
                new AssetType {Id = 3, Name="Phone" }
                );

            //seed data created for Asset table for test data

            modelBuilder.Entity<Asset>().HasData(
             new Asset { Id = 1, TagNo = "1234", Manufacturer = "Computer", Model = "Dell", Description = "Computers by Dell", SNo = "C2DELL", AssetTypeId = 1 },
             new Asset { Id = 2, TagNo = "1034", Manufacturer = "Computer", Model = "HP", Description = "Computers by HP", SNo = "C1HP", AssetTypeId = 1 },
             new Asset { Id = 3, TagNo = "1205", Manufacturer = "Computer", Model = "Acer", Description = "Computers by Acer", SNo = "C1ACER", AssetTypeId = 1 },
             new Asset { Id = 4, TagNo = "5401", Manufacturer = "Monitor", Model = "Acer", Description = "Monitors by Acer", SNo = "M2ACER", AssetTypeId = 2 },
             new Asset { Id = 5, TagNo = "1204", Manufacturer = "Monitor", Model = "LG", Description = "Monitors By LG", SNo = "M3LG", AssetTypeId = 2 },
             new Asset { Id = 6, TagNo = "1001", Manufacturer = "Monitor", Model = "HP", Description = "Monitors By HP", SNo = "M1HP", AssetTypeId = 2 },
             new Asset { Id = 7, TagNo = "1308", Manufacturer = "Phone", Model = "Avaya", Description = "Phones By Avaya", SNo = "P4AVAYA", AssetTypeId = 3 },
             new Asset { Id = 8, TagNo = "1400", Manufacturer = "Phone", Model = "Polycom", Description = "Phones By Polycom", SNo = "P3PPLY", AssetTypeId = 3 },
             new Asset { Id = 9, TagNo = "1604", Manufacturer = "Phone", Model = "Cisco", Description = "Phones By Cisco", SNo = "P9CISCO", AssetTypeId = 3 }
             
             );

            
        }

    }
}
