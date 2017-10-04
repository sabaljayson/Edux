﻿// <auto-generated />
using Edux.Data;
using Edux.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Edux.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170921120949_appProperties")]
    partial class appProperties
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Edux.Models.App", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AllowedRoles");

                    b.Property<string>("AppTenantId")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("DefaultLayout")
                        .HasMaxLength(200);

                    b.Property<string>("DefaultPage")
                        .HasMaxLength(200);

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Apps");
                });

            modelBuilder.Entity("Edux.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("AppTenantId")
                        .HasMaxLength(200);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Edux.Models.Chart", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppTenantId")
                        .HasMaxLength(200);

                    b.Property<string>("AxisXDisplayFormat")
                        .HasMaxLength(200);

                    b.Property<string>("AxisXEntity")
                        .HasMaxLength(200);

                    b.Property<string>("AxisXProperty")
                        .HasMaxLength(200);

                    b.Property<string>("AxisYDisplayFormat")
                        .HasMaxLength(200);

                    b.Property<string>("AxisYEntity")
                        .HasMaxLength(200);

                    b.Property<string>("AxisYProperty")
                        .HasMaxLength(200);

                    b.Property<string>("AxisZDisplayFormat")
                        .HasMaxLength(200);

                    b.Property<string>("AxisZEntity")
                        .HasMaxLength(200);

                    b.Property<string>("AxisZPropert")
                        .HasMaxLength(200);

                    b.Property<int>("CharType");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("DisplayName")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Charts");
                });

            modelBuilder.Entity("Edux.Models.Column", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppTenantId")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("DataTableId");

                    b.Property<string>("EntityId");

                    b.Property<int>("FilterOperator");

                    b.Property<string>("FilterValue")
                        .HasMaxLength(200);

                    b.Property<bool?>("OrderBy");

                    b.Property<int>("Position");

                    b.Property<string>("PropertyId");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("DataTableId");

                    b.HasIndex("EntityId");

                    b.HasIndex("PropertyId");

                    b.ToTable("Columns");
                });

            modelBuilder.Entity("Edux.Models.Component", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppTenantId")
                        .HasMaxLength(200);

                    b.Property<string>("ComponentTypeId");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("PageId");

                    b.Property<string>("ParentComponentId");

                    b.Property<int>("Position");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("View")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ComponentTypeId");

                    b.HasIndex("PageId");

                    b.HasIndex("ParentComponentId");

                    b.ToTable("Components");
                });

            modelBuilder.Entity("Edux.Models.ComponentType", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppTenantId")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("ComponentTypes");
                });

            modelBuilder.Entity("Edux.Models.DataTable", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppTenantId")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("EntityName")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("Top");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("DataTables");
                });

            modelBuilder.Entity("Edux.Models.Entity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppTenantId")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("OnLoad");

                    b.Property<string>("PluralName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Entities");
                });

            modelBuilder.Entity("Edux.Models.Field", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppTenantId")
                        .HasMaxLength(200);

                    b.Property<int>("Col");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("CssClass")
                        .HasMaxLength(200);

                    b.Property<string>("DefaultValue");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("EditorType");

                    b.Property<string>("EntityId");

                    b.Property<string>("FormId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("OnChange")
                        .HasMaxLength(200);

                    b.Property<string>("OnClick")
                        .HasMaxLength(200);

                    b.Property<string>("OptionLabel")
                        .HasMaxLength(200);

                    b.Property<int>("Position");

                    b.Property<string>("PropertyId");

                    b.Property<string>("PropertyValueId");

                    b.Property<int>("Row");

                    b.Property<string>("Tab")
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("EntityId");

                    b.HasIndex("FormId");

                    b.HasIndex("PropertyId");

                    b.HasIndex("PropertyValueId");

                    b.ToTable("Fields");
                });

            modelBuilder.Entity("Edux.Models.Form", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppTenantId")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("EntityName")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Forms");
                });

            modelBuilder.Entity("Edux.Models.Language", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppTenantId")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("Culture")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("NativeName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Edux.Models.Media", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppTenantId")
                        .HasMaxLength(200);

                    b.Property<string>("ContentType")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("Description");

                    b.Property<string>("Extension")
                        .HasMaxLength(200);

                    b.Property<string>("FilePath")
                        .HasMaxLength(200);

                    b.Property<double?>("FileSize");

                    b.Property<int>("Month");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.ToTable("Media");
                });

            modelBuilder.Entity("Edux.Models.Menu", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppTenantId")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("MenuLocation")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("Edux.Models.MenuItem", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppTenantId")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("CssClass")
                        .HasMaxLength(200);

                    b.Property<string>("Icon")
                        .HasMaxLength(200);

                    b.Property<bool>("IsPublished");

                    b.Property<string>("MenuId")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("ParentMenuItemId");

                    b.Property<int>("Position");

                    b.Property<string>("Target")
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("Url")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.HasIndex("ParentMenuItemId");

                    b.ToTable("MenuItems");
                });

            modelBuilder.Entity("Edux.Models.Page", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AllowedRoles");

                    b.Property<string>("AppId");

                    b.Property<string>("AppTenantId")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<bool>("IsPublished");

                    b.Property<string>("LanguageId");

                    b.Property<string>("LayoutView")
                        .HasMaxLength(200);

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKeywords");

                    b.Property<string>("MetaTitle");

                    b.Property<string>("ParentPageId");

                    b.Property<long>("Position");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("View")
                        .HasMaxLength(200);

                    b.Property<long>("ViewCount");

                    b.HasKey("Id");

                    b.HasIndex("AppId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("ParentPageId");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("Edux.Models.Parameter", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppTenantId")
                        .HasMaxLength(200);

                    b.Property<string>("ComponentTypeId");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<bool>("IsRequired");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("Position");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ComponentTypeId");

                    b.ToTable("Parameters");
                });

            modelBuilder.Entity("Edux.Models.ParameterValue", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppTenantId")
                        .HasMaxLength(200);

                    b.Property<string>("ComponentId");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("ParameterId");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("ComponentId");

                    b.HasIndex("ParameterId");

                    b.ToTable("ParameterValues");
                });

            modelBuilder.Entity("Edux.Models.Property", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppTenantId")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("DataSourceEntityId");

                    b.Property<string>("DataSourcePropertyId");

                    b.Property<string>("DefaultValue");

                    b.Property<string>("DisplayFormat")
                        .HasMaxLength(200);

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("EntityId");

                    b.Property<bool>("IsRequired");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("Position");

                    b.Property<string>("PresetValues");

                    b.Property<int>("PropertyType");

                    b.Property<int>("StringLength");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("DataSourceEntityId");

                    b.HasIndex("DataSourcePropertyId");

                    b.HasIndex("EntityId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("Edux.Models.PropertyValue", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppTenantId")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("EntityId");

                    b.Property<string>("PropertyId");

                    b.Property<long>("RowId");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("EntityId");

                    b.HasIndex("PropertyId");

                    b.ToTable("PropertyValues");
                });

            modelBuilder.Entity("Edux.Models.Role", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppTenantId")
                        .HasMaxLength(200);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Edux.Models.Setting", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppTenantId")
                        .HasMaxLength(200);

                    b.Property<string>("ComponentViews");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(200);

                    b.Property<string>("LayoutViews");

                    b.Property<string>("PageViews");

                    b.Property<string>("SmtpHost")
                        .HasMaxLength(200);

                    b.Property<string>("SmtpPassword")
                        .HasMaxLength(200);

                    b.Property<string>("SmtpPort")
                        .HasMaxLength(200);

                    b.Property<bool>("SmtpUseSSL");

                    b.Property<string>("SmtpUserName")
                        .HasMaxLength(200);

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Edux.Models.Column", b =>
                {
                    b.HasOne("Edux.Models.DataTable", "DataTable")
                        .WithMany("Columns")
                        .HasForeignKey("DataTableId");

                    b.HasOne("Edux.Models.Entity", "Entity")
                        .WithMany("Columns")
                        .HasForeignKey("EntityId");

                    b.HasOne("Edux.Models.Property", "Property")
                        .WithMany()
                        .HasForeignKey("PropertyId");
                });

            modelBuilder.Entity("Edux.Models.Component", b =>
                {
                    b.HasOne("Edux.Models.ComponentType", "ComponentType")
                        .WithMany()
                        .HasForeignKey("ComponentTypeId");

                    b.HasOne("Edux.Models.Page", "Page")
                        .WithMany("Components")
                        .HasForeignKey("PageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Edux.Models.Component", "ParentComponent")
                        .WithMany("ChildComponents")
                        .HasForeignKey("ParentComponentId");
                });

            modelBuilder.Entity("Edux.Models.Field", b =>
                {
                    b.HasOne("Edux.Models.Entity", "Entity")
                        .WithMany()
                        .HasForeignKey("EntityId");

                    b.HasOne("Edux.Models.Form", "Form")
                        .WithMany("Fields")
                        .HasForeignKey("FormId");

                    b.HasOne("Edux.Models.Property", "Property")
                        .WithMany()
                        .HasForeignKey("PropertyId");

                    b.HasOne("Edux.Models.PropertyValue", "PropertyValue")
                        .WithMany()
                        .HasForeignKey("PropertyValueId");
                });

            modelBuilder.Entity("Edux.Models.MenuItem", b =>
                {
                    b.HasOne("Edux.Models.Menu", "Menu")
                        .WithMany("MenuItems")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Edux.Models.MenuItem", "ParentMenuItem")
                        .WithMany("ChildMenuItems")
                        .HasForeignKey("ParentMenuItemId");
                });

            modelBuilder.Entity("Edux.Models.Page", b =>
                {
                    b.HasOne("Edux.Models.App", "App")
                        .WithMany("Pages")
                        .HasForeignKey("AppId");

                    b.HasOne("Edux.Models.Language", "Language")
                        .WithMany("Pages")
                        .HasForeignKey("LanguageId");

                    b.HasOne("Edux.Models.Page", "ParentPage")
                        .WithMany("ChildPages")
                        .HasForeignKey("ParentPageId");
                });

            modelBuilder.Entity("Edux.Models.Parameter", b =>
                {
                    b.HasOne("Edux.Models.ComponentType", "ComponentType")
                        .WithMany("Parameters")
                        .HasForeignKey("ComponentTypeId");
                });

            modelBuilder.Entity("Edux.Models.ParameterValue", b =>
                {
                    b.HasOne("Edux.Models.Component", "Component")
                        .WithMany("ParameterValues")
                        .HasForeignKey("ComponentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Edux.Models.Parameter", "Parameter")
                        .WithMany("ParameterValues")
                        .HasForeignKey("ParameterId");
                });

            modelBuilder.Entity("Edux.Models.Property", b =>
                {
                    b.HasOne("Edux.Models.Entity", "DataSourceEntity")
                        .WithMany("DataSourceProperties")
                        .HasForeignKey("DataSourceEntityId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Edux.Models.Property", "DataSourceProperty")
                        .WithMany()
                        .HasForeignKey("DataSourcePropertyId");

                    b.HasOne("Edux.Models.Entity", "Entity")
                        .WithMany("Properties")
                        .HasForeignKey("EntityId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Edux.Models.PropertyValue", b =>
                {
                    b.HasOne("Edux.Models.Entity", "Entity")
                        .WithMany("PropertyValues")
                        .HasForeignKey("EntityId");

                    b.HasOne("Edux.Models.Property", "Property")
                        .WithMany("PropertyValues")
                        .HasForeignKey("PropertyId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Edux.Models.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Edux.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Edux.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Edux.Models.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Edux.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Edux.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}