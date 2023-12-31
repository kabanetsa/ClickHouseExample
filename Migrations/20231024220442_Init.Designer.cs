﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClickHouseExample.Migrations
{
    [DbContext(typeof(ClickHouseContext))]
    [Migration("20231024220442_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("ClickHouseExample.WeatherForecast", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("UUID");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("Date");

                    b.Property<string>("Summary")
                        .HasColumnType("String");

                    b.Property<int>("TemperatureC")
                        .HasColumnType("Int32");

                    b.HasKey("Id");

                    b.ToTable("WeatherForecast", "default");

                    b.HasAnnotation("MergeTreeEngine_ClickHouse:Engine", "{\"EngineType\":\"MergeTreeEngine_ClickHouse:Engine\",\"OrderBy\":\"Id\",\"PartitionBy\":null,\"PrimaryKey\":null,\"SampleBy\":null,\"Settings\":{\"IndexGranularity\":8192,\"IndexGranularityBytes\":10485760,\"MinIndexGranularityBytes\":1024,\"EnableMixedGranularityParts\":false,\"UseMinimalisticPartHeaderInZookeeper\":false,\"MinMergeBytesToUseDirectIo\":10737418240,\"MergeWithTtlTimeout\":\"1.00:00:00\",\"WriteFinalMark\":false,\"MergeMaxBlockSize\":8192,\"StoragePolicy\":null,\"MinBytesForWidePart\":null,\"MinRowsForWidePart\":null,\"MaxPartsInTotal\":null,\"MaxCompressBlockSize\":null,\"MinCompressBlockSize\":null,\"IsDefault\":true}}");
                });
#pragma warning restore 612, 618
        }
    }
}
