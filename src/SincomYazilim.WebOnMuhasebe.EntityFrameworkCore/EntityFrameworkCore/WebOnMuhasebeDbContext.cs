
using System.Data;
using Microsoft.EntityFrameworkCore;
using SincomYazilim.WebOnMuhasebe.BankaHesaplar.Concrete;
using SincomYazilim.WebOnMuhasebe.Bankalar.Concrete;
using SincomYazilim.WebOnMuhasebe.BankaSubeler.Concrete;
using SincomYazilim.WebOnMuhasebe.Birimler.Concrete;
using SincomYazilim.WebOnMuhasebe.Cariler.Concrete;
using SincomYazilim.WebOnMuhasebe.Consts;
using SincomYazilim.WebOnMuhasebe.Depolar.Concrete;
using SincomYazilim.WebOnMuhasebe.Donemler.Concrete;
using SincomYazilim.WebOnMuhasebe.Faturalar.Concrete;
using SincomYazilim.WebOnMuhasebe.Hizmetler.Concrete;
using SincomYazilim.WebOnMuhasebe.Kasalar.Concrete;
using SincomYazilim.WebOnMuhasebe.Makbuzlar.Concrete;
using SincomYazilim.WebOnMuhasebe.Masraflar.Concrete;
using SincomYazilim.WebOnMuhasebe.OzelKodlar.Concrete;
using SincomYazilim.WebOnMuhasebe.Parametreler.Concrete;
using SincomYazilim.WebOnMuhasebe.SinConfigurations;
using SincomYazilim.WebOnMuhasebe.Stoklar.Concrete;
using SincomYazilim.WebOnMuhasebe.Subeler.Concrete;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace SincomYazilim.WebOnMuhasebe.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]//Identıy dbsetlerı burda
[ReplaceDbContext(typeof(ITenantManagementDbContext))]//app dbsetlerı burda
[ConnectionStringName("Default")]
public class WebOnMuhasebeDbContext :
    AbpDbContext<WebOnMuhasebeDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion
    // biz ekledık 43 video    bızım dbsetlerı eklıyoruz 01,05,2023
    public DbSet<Banka> Bankalar { get; set; }
    public DbSet<BankaSube> BankaSubeler { get; set; }
    public DbSet<BankaHesap> BankaHesaplar { get; set; }
    public DbSet<Birim> Birimler { get; set; }
    public DbSet<Cari> Cariler { get; set; }
    public DbSet<Depo> Depolar { get; set; }
    public DbSet<Donem> Donemler { get; set; }
    public DbSet<FirmaParemetre> FirmaParemetreler { get; set; }
    public DbSet<Fatura> Faturalar { get; set; }
    public DbSet<Hizmet> Hizmetler { get; set; }
    public DbSet<Kasa> Kasalar { get; set; }
    public DbSet<Makbuz> Makbuzlar { get; set; }
    public DbSet<Masraf> Masraflar { get; set; }
    public DbSet<OzelKod> OzelKodlar { get; set; }
    public DbSet<Stok> Stoklar { get; set; }
    public DbSet<Sube> Subeler { get; set; }


    public WebOnMuhasebeDbContext(DbContextOptions<WebOnMuhasebeDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureIdentityServer();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        /* Configure your own tables/entities inside here */

        builder.ConfigureBanka();//video 45
        builder.ConfigureBankaSube();//video 46
        builder.ConfigureBankaHesap();//video 47
        builder.ConfigureBirim();//video 48
        builder.ConfigureCari();//video 49
        builder.ConfigureDepo();//video 50
        builder.ConfigureDonem();//video 51
        builder.ConfigureFatura();//video 52
        builder.ConfigureFaturaHareket();//video 53
        builder.ConfigureFirmaParemetre();//video 54
        builder.ConfigureHizmet();//video 55
        builder.ConfigureKasa();//video 56
        builder.ConfigureMakbuz();//video 57
        builder.ConfigureMakbuzHareket();//video 58
        builder.ConfigureMasraf();//video 59
        builder.ConfigureOzelKod();//video 60
        builder.ConfigureStok();//video 61
        builder.ConfigureSube();//video 62
    }
}
