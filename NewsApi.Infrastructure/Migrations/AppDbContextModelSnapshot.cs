﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewsApi.Infrastructure.Context;

#nullable disable

namespace NewsApi.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NewsApi.Core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Category about sport",
                            Name = "Sport"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Category about cience",
                            Name = "Cience"
                        });
                });

            modelBuilder.Entity("NewsApi.Core.Entities.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("News");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Український боксер надважкої ваги Олександр Усик 29 січня вчетверте став батьком. Його дружина Катерина в одному з пологових будинків Києва народила дівчинку.\r\n\r\nПро це у своєму Youtube-каналі повідомив шоумен та ведучий Слава Дьомін.",
                            FullText = "Український боксер надважкої ваги Олександр Усик 29 січня вчетверте став батьком. Його дружина Катерина в одному з пологових будинків Києва народила дівчинку.\r\n\r\nПро це у своєму Youtube-каналі повідомив шоумен та ведучий Слава Дьомін.\r\n\r\nНовонароджена донька Олександра важить п'ять кілограмів і має 58 сантиметрів зросту. Дівчинці вже дали ім'я — Марія.\r\n\r\nВарто зазначити, що в Олександра і Катерини вже є троє дітей: дочка Єлизавета та сини Михайло і Кирило.\r\n\r\nЦікаво, що 17 лютого відбудеться бій за звання абсолютного чемпіона світу Усик — Ф’юрі. Поєдинок пройде в Саудівській Аравії.,",
                            Title = "У родині Усиків поповнення: український боксер вчетверте став батьком"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "Під час обідньої перерви у космосі варто утриматися від салату. До такого висновку дійшли дослідники Делаверського університету в США. Вчені виростили різні овочі в умовах мікрогравітації на Землі та виявили, що салати важко борються зі шкідливими бактеріями в космічному середовищі.",
                            FullText = "Салат на Міжнародній космічній станції (МКС) — це справжній хіт. Астронавти вирощують овочі у межах різних експериментів, причому частину врожаю вони навіть споживають, що є здоровою альтернативою сублімованим та консервованим продуктам. Проте результати нових досліджень доводять, що рослини, вирощені в умовах мікрогравітації, більш вразливі до інфекцій, таких як кишкова паличка чи сальмонела.\r\n\r\nУ науковій статті, що з’явилася в Scientific Reports, рослини вирощували у пристрої, який їх обертав, і виявили, що в умовах мікрогравітації їхній природний захист ставав менш ефективним. Рослини втрачають орієнтацію в гравітації, що впливає на їхній розвиток і, як наслідок, на реакцію на стрес.",
                            Title = "Вирощені на орбіті овочі становлять небезпеку для здоров’я астронавтів"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
