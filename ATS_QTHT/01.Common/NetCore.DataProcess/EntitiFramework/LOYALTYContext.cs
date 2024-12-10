using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCore.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using NetCore.Models.Business;
using NetCore.Models.Business.Order;
using NetCore.Models.PromotionModels;
using NetCore.PaymentGate;
using NetCore.Models.MasterData;
using NetCore.Models.PromotionModels;
using NetCore.Models;
using NetCore.Core.Base;

namespace NetCore.DataProcess.EntitiFramework
{
    public class LOYALTYContext : DbContext
    {
        public LOYALTYContext(DbContextOptions<LOYALTYContext> options) : base(options)
        {
        }

        // Authen
        public DbSet<Function> Functions { get; set; }
        public DbSet<Action1> Actions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PartnerTable> PartnerTables { get; set; }
        public DbSet<UserAccessToken> UserAccessTokens { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<UserPermission> UserPermissions { get; set; }
        public DbSet<UserGroupPermission> UserGroupPermissions { get; set; }

        // MasterData
        public DbSet<AppVersion> AppVersions { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategorys { get; set; }
        public DbSet<OtherList> OtherLists { get; set; }
        public DbSet<OtherListType> OtherListTypes { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductVersion> ProductVersions { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<ProductLabel> ProductLabels { get; set; }
        public DbSet<CustomerRank> CustomerRanks { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<NotificationType> NotificationTypes { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<StaticPage> StaticPages { get; set; }

        public DbSet<Offending_Words> offending_Words { get; set; }

        // Common
        public DbSet<Logging> Loggings { get; set; }
        public DbSet<OTPTransaction> OTPTransactions { get; set; }
        public DbSet<UserNotification> UserNotifications { get; set; }

        // Configuration
        public DbSet<AccumulatePointConfig> AccumulatePointConfigs { get; set; }
        public DbSet<AccumulatePointConfigDetail> AccumulatePointConfigDetails { get; set; }
        public DbSet<AffiliateConfig> AffiliateConfigs { get; set; }
        public DbSet<AffiliateConfigDetail> AffiliateConfigDetails { get; set; }
        public DbSet<BonusPointConfig> BonusPointConfigs { get; set; }
        public DbSet<ConfigHistory> ConfigHistorys { get; set; }
        public DbSet<CustomerRankConfig> CustomerRankConfigs { get; set; }
        public DbSet<EstimateApprovePoint> EstimateApprovePoints { get; set; }
        public DbSet<EstimateApprovePointDetail> EstimateApprovePointDetails { get; set; }
        public DbSet<ExchangePointPackConfig> ExchangePointPackConfigs { get; set; }
        public DbSet<LoadPointPackConfig> LoadPointPackConfigs { get; set; }
        public DbSet<RatingConfig> RatingConfigs { get; set; }
        public DbSet<Settings> Settingses { get; set; }
        public DbSet<AppSuggestSearch> AppSuggestSearchs { get; set; }

        public DbSet<NotiConfig> NotiConfigs { get; set; }

        // Business
        public DbSet<CustomerPartnerRecent> CustomerPartnerRecents { get; set; }
        public DbSet<ProductCurrentVersion> ProductCurrentVersions { get; set; }
        public DbSet<ProductMenuComboCurrentVersion> ProductMenuComboCurrentVersions { get; set; }
        public DbSet<AccumulatePointOrder> AccumulatePointOrders { get; set; }
        public DbSet<AccumulatePointOrderDetail> AccumulatePointOrderDetails { get; set; }
        public DbSet<AccumulatePointOrderRating> AccumulatePointOrderRatings { get; set; }
        public DbSet<AccumulatePointOrderAffiliate> AccumulatePointOrderAffiliates { get; set; }
        public DbSet<AddPointOrder> AddPointOrders { get; set; }
        public DbSet<ComplainInfo> ComplainInfos { get; set; }
        public DbSet<AccumulatePointOrderComplain> AccumulatePointOrderComplains { get; set; }
        public DbSet<Models.BankAccount> BankAccounts { get; set; }
        public DbSet<CmsNotification> CmsNotifications { get; set; }
        public DbSet<ChangePointOrder> ChangePointOrders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<SmsProvider> SmsProvider { get; set; }
        public DbSet<CustomerBankAccount> CustomerBankAccounts { get; set; }
        public DbSet<CustomerFakeBank> CustomerFakeBanks { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<CompanyBranch> CompanyBranchs { get; set; }
        public DbSet<PartnerContact> PartnerContacts { get; set; }
        public DbSet<PartnerContractLog> PartnerContractLogs { get; set; }
        public DbSet<PartnerRepresentativeInfo> PartnerRepresentativeInfos { get; set; }
        public DbSet<PartnerAccNo> PartnerAccNos { get; set; }
        public DbSet<PartnerBranchAccNo> PartnerBranchAccNos { get; set; }
        public DbSet<PartnerWorkingTime> PartnerWorkingTimes { get; set; }
        public DbSet<PartnerDocument> PartnerDocuments { get; set; }
        public DbSet<PartnerFavourite> PartnerFavourites { get; set; }
        public DbSet<PartnerBag> PartnerBags { get; set; }
        public DbSet<PartnerContract> PartnerContracts { get; set; }
        public DbSet<MenuImage> MenuImages { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<OrderStatistic> OrderStatistics { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductMenu> ProductMenus { get; set; }
        public DbSet<ProductMenuGroup> ProductMenuGroups { get; set; }
        public DbSet<ProductMenuCombo> ProductMenuCombos { get; set; }
        public DbSet<PartnerOrder> PartnerOrders { get; set; }
        public DbSet<PartnerOrderDetail> PartnerOrderDetails { get; set; }
        public DbSet<PartnerFileContract> PartnerFileContracts { get; set; }
        public DbSet<RecallPointOrder> RecallPointOrders { get; set; }
        public DbSet<Accessary> Accessaries { get; set; }
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<AgencyAffiliateConfig> AgencyAffiliateConfigs { get; set; }
        public DbSet<BKCallbackRequestModel> BKCallbackRequests { get; set; }
        public DbSet<BlueLinkCallbackRequestModel> BlueLinkCallbackRequests { get; set; }

        // Report
        public DbSet<CustomerPointHistory> CustomerPointHistorys { get; set; }
        public DbSet<PartnerPointHistory> PartnerPointHistories { get; set; }
        public DbSet<SystemPointHistory> SystemPointHistorys { get; set; }
        public DbSet<SysAmountHistory> SysAmountHistorys { get; set; }
        public DbSet<SysAmountSummary> SysAmountSummarys { get; set; }

        // Payment Gate
        public DbSet<BKVATransaction> BKVATransactions { get; set; }
        public DbSet<BaoKimTransaction> BaoKimTransactions { get; set; }

        // Schedule
        public DbSet<ScheduleJobs> ScheduleJobss { get; set; }

        //SMSHistory
        public DbSet<SMSHistory> SMSHistories { get; set; }
        public DbSet<MobileVersion> MobileVersions { get; set; }
        public DbSet<IndustryGroup> IndustryGroups { get; set; }
        public DbSet<Industry> Industries { get; set; }

        public DbSet<SubServiceType> SubServiceTypes { get; set; }
        
        public DbSet<ServiceTypeTag> ServiceTypeTags { get; set; }
        
        public DbSet<ServiceType_ServiceTypeTag> ServiceType_ServiceTypeTags { get; set; }
        public DbSet<Parrtner_ServiceTypeTag> Parrtner_ServiceTypeTags { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<PartnerInvoice> PartnerInvoices { get; set; }

        public DbSet<InvoiceTotalModel> InvoiceTotals { get; set; }

        public DbSet<BaoKimCollectionTransaction> BaoKimCollectionTransactions { get; set; }
        
        public DbSet<BaoKimSettlementTransaction> BaoKimSettlementTransactions { get; set; }
        
        
        public DbSet<StatisticRevenueDaily> StatisticRevenueDailies { get; set; }
        
        // Promotions
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Gift> Gifts { get; set; }
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<ConditionGift> ConditionGifts { get; set; }
        public DbSet<RewardHistory> RewardHistorys { get; set; }
        public DbSet<TransactionForReward> TransactionForRewards { get; set; }

        public DbSet<PromotionUser> PromotionUsers { get; set; }
        public DbSet<PhasePromotion> PhasePromotions { get; set; }
        public DbSet<GiftHistory> GiftHistorys { get; set; }
        public DbSet<TableMessage> TableMessages { get; set; }



        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Authen
            modelBuilder.Entity<Function>().ToTable("Function").HasKey(v => v.id);
            modelBuilder.Entity<Action1>().ToTable("Action").HasKey(v => v.id);
            modelBuilder.Entity<User>().ToTable("User").HasKey(v => v.id);
            modelBuilder.Entity<PartnerTable>().ToTable("PartnerTable").HasKey(v => v.id);
            modelBuilder.Entity<Menu>().ToTable("Menu").HasKey(v => v.id);
            modelBuilder.Entity<MenuImage>().ToTable("MenuImage").HasKey(v => v.id);
            modelBuilder.Entity<Cart>().ToTable("Cart").HasKey(v => v.id);
            modelBuilder.Entity<CartItem>().ToTable("CartItem").HasKey(v => v.id);
            modelBuilder.Entity<Order>().ToTable("Order").HasKey(v => v.id);
            modelBuilder.Entity<OrderItem>().ToTable("OrderItem").HasKey(v => v.id);
            modelBuilder.Entity<OrderStatistic>().ToTable("OrderStatistic").HasKey(v => v.id);
            modelBuilder.Entity<UserAccessToken>().ToTable("UserAccessToken").HasKey(v => v.id);
            modelBuilder.Entity<UserGroup>().ToTable("UserGroup").HasKey(v => v.id);
            modelBuilder.Entity<UserPermission>().ToTable("UserPermission").HasKey(v => v.id);
            modelBuilder.Entity<UserGroupPermission>().ToTable("UserGroupPermission").HasKey(v => v.id);

            // Common
            modelBuilder.Entity<Logging>().ToTable("Logging").HasKey(v => v.id);
            modelBuilder.Entity<UserNotification>().ToTable("UserNotification").HasKey(v => new { v.notification_id, v.user_id });
            modelBuilder.Entity<OTPTransaction>().ToTable("OTPTransaction").HasKey(v => v.otp_code);

            // Master Data
            modelBuilder.Entity<AppVersion>().ToTable("AppVersion").HasKey(v => v.id);
            modelBuilder.Entity<Bank>().ToTable("Bank").HasKey(v => v.id);
            modelBuilder.Entity<Banner>().ToTable("Banner").HasKey(v => v.id);
            modelBuilder.Entity<Blog>().ToTable("Blog").HasKey(v => v.id);
            modelBuilder.Entity<BlogCategory>().ToTable("BlogCategory").HasKey(v => v.id);
            modelBuilder.Entity<OtherList>().ToTable("OtherList").HasKey(v => v.id);
            modelBuilder.Entity<OtherListType>().ToTable("OtherListType").HasKey(v => v.id);
            modelBuilder.Entity<Province>().ToTable("Province").HasKey(v => v.id);
            modelBuilder.Entity<ProductGroup>().ToTable("ProductGroup").HasKey(v => v.id);
            modelBuilder.Entity<ProductMenu>().ToTable("ProductMenu").HasKey(v => v.id);
            modelBuilder.Entity<ProductMenuGroup>().ToTable("ProductMenuGroup").HasKey(v => v.id);
            modelBuilder.Entity<ProductMenuCombo>().ToTable("ProductMenuCombo").HasKey(v => v.id);
            modelBuilder.Entity<Menu>().ToTable("Menu").HasKey(v => v.id);
            modelBuilder.Entity<Product>().ToTable("Product").HasKey(v => v.id);
            modelBuilder.Entity<CustomerRank>().ToTable("CustomerRank").HasKey(v => v.id);
            modelBuilder.Entity<ProductImage>().ToTable("ProductImage").HasKey(v => v.id);
            modelBuilder.Entity<ProductLabel>().ToTable("ProductLabel").HasKey(v => v.id);
            modelBuilder.Entity<ServiceType>().ToTable("ServiceType").HasKey(v => v.id);
            modelBuilder.Entity<NotificationType>().ToTable("NotificationType").HasKey(v => v.id);
            modelBuilder.Entity<Notification>().ToTable("Notification").HasKey(v => v.id);
            modelBuilder.Entity<StaticPage>().ToTable("StaticPage").HasKey(v => v.id);
            modelBuilder.Entity<IndustryGroup>().ToTable("IndustryGroup").HasKey(v => v.id);
            modelBuilder.Entity<Industry>().ToTable("Industry").HasKey(v => v.id);

            // Configuration
            modelBuilder.Entity<AccumulatePointConfig>().ToTable("AccumulatePointConfig").HasKey(v => v.id);
            modelBuilder.Entity<AccumulatePointConfigDetail>().ToTable("AccumulatePointConfigDetail").HasKey(v => v.id);
            modelBuilder.Entity<AffiliateConfig>().ToTable("AffiliateConfig").HasKey(v => v.id);
            modelBuilder.Entity<AffiliateConfigDetail>().ToTable("AffiliateConfigDetail").HasKey(v => v.id);
            modelBuilder.Entity<BonusPointConfig>().ToTable("BonusPointConfig").HasKey(v => v.id);
            modelBuilder.Entity<ConfigHistory>().ToTable("ConfigHistory").HasKey(v => v.id);
            modelBuilder.Entity<CustomerRankConfig>().ToTable("CustomerRankConfig").HasKey(v => v.id);
            modelBuilder.Entity<EstimateApprovePoint>().ToTable("EstimateApprovePoint").HasKey(v => v.id);
            modelBuilder.Entity<EstimateApprovePointDetail>().ToTable("EstimateApprovePointDetail").HasKey(v => v.id);
            modelBuilder.Entity<ExchangePointPackConfig>().ToTable("ExchangePointPackConfig").HasKey(v => v.id);
            modelBuilder.Entity<LoadPointPackConfig>().ToTable("LoadPointPackConfig").HasKey(v => v.id);
            modelBuilder.Entity<RatingConfig>().ToTable("RatingConfig").HasKey(v => v.id);
            modelBuilder.Entity<Settings>().ToTable("Settings").HasKey(v => v.id);
            modelBuilder.Entity<NotiConfig>().ToTable("NotiConfig").HasKey(v => v.id);
            modelBuilder.Entity<AppSuggestSearch>().ToTable("AppSuggestSearch").HasKey(v => v.id);

            // Business
            modelBuilder.Entity<AccumulatePointOrder>().ToTable("AccumulatePointOrder").HasKey(v => v.id);
            modelBuilder.Entity<AccumulatePointOrderRating>().ToTable("AccumulatePointOrderRating").HasKey(v => v.id);
            modelBuilder.Entity<AccumulatePointOrderDetail>().ToTable("AccumulatePointOrderDetail").HasKey(v => v.id);
            modelBuilder.Entity<AccumulatePointOrderAffiliate>().ToTable("AccumulatePointOrderAffiliate").HasKey(v => v.id);
            modelBuilder.Entity<AddPointOrder>().ToTable("AddPointOrder").HasKey(v => v.id);
            modelBuilder.Entity<ComplainInfo>().ToTable("ComplainInfo").HasKey(v => v.id);
            modelBuilder.Entity<AccumulatePointOrderComplain>().ToTable("AccumulatePointOrderComplain").HasKey(v => v.id);
            modelBuilder.Entity<Models.BankAccount>().ToTable("BankAccount").HasKey(v => v.id);
            modelBuilder.Entity<ChangePointOrder>().ToTable("ChangePointOrder").HasKey(v => v.id);
            modelBuilder.Entity<Customer>().ToTable("Customer").HasKey(v => v.id);
            modelBuilder.Entity<CustomerBankAccount>().ToTable("CustomerBankAccount").HasKey(v => v.id);
            modelBuilder.Entity<CustomerFakeBank>().ToTable("CustomerFakeBank").HasKey(v => v.id);
            modelBuilder.Entity<Partner>().ToTable("Partner").HasKey(v => v.id);
            modelBuilder.Entity<PartnerAccNo>().ToTable("PartnerAccNo").HasKey(v => v.id);
            modelBuilder.Entity<PartnerBranchAccNo>().ToTable("PartnerBranchAccNo").HasKey(v => v.id);
            modelBuilder.Entity<PartnerWorkingTime>().ToTable("PartnerWorkingTime").HasKey(v => v.id);
            modelBuilder.Entity<PartnerRepresentativeInfo>().ToTable("PartnerRepresentativeInfo").HasKey(v => v.id);
            modelBuilder.Entity<PartnerContact>().ToTable("PartnerContact").HasKey(v => v.id);
            modelBuilder.Entity<PartnerContractLog>().ToTable("PartnerContractLog").HasKey(v => v.id);
            modelBuilder.Entity<PartnerBag>().ToTable("PartnerBag").HasKey(v => v.id);
            modelBuilder.Entity<PartnerDocument>().ToTable("PartnerDocument").HasKey(v => v.id);
            modelBuilder.Entity<PartnerFavourite>().ToTable("PartnerFavourite").HasKey(v => new { v.customer_id, v.partner_id });
            modelBuilder.Entity<PartnerContract>().ToTable("PartnerContract").HasKey(v => v.id);
            modelBuilder.Entity<PartnerOrder>().ToTable("PartnerOrder").HasKey(v => v.id);
            modelBuilder.Entity<PartnerOrderDetail>().ToTable("PartnerOrderDetail").HasKey(v => v.id);
            modelBuilder.Entity<RecallPointOrder>().ToTable("RecallPointOrder").HasKey(v => v.id);
            modelBuilder.Entity<CompanyBranch>().ToTable("CompanyBranch").HasKey(v => v.id);
            modelBuilder.Entity<CmsNotification>().ToTable("CmsNotification").HasKey(v => v.id);

            // Report
            modelBuilder.Entity<CustomerPointHistory>().ToTable("CustomerPointHistory").HasKey(v => v.id);
            modelBuilder.Entity<PartnerPointHistory>().ToTable("PartnerPointHistory").HasKey(v => v.id);
            modelBuilder.Entity<SystemPointHistory>().ToTable("SystemPointHistory").HasKey(v => v.id);
            modelBuilder.Entity<SysAmountHistory>().ToTable("SysAmountHistory").HasKey(v => v.id);
            modelBuilder.Entity<SysAmountSummary>().ToTable("SysAmountSummary").HasKey(v => v.id);

            // Payment Gate
            modelBuilder.Entity<BKVATransaction>().ToTable("BKVATransaction").HasKey(v => v.RequestId);
            modelBuilder.Entity<BaoKimTransaction>().ToTable("BaoKimTransaction").HasKey(v => v.id);

            // Schedule Jobs
            modelBuilder.Entity<ScheduleJobs>().ToTable("ScheduleJobs").HasKey(v => v.id);

            modelBuilder.Entity<StatisticRevenueDaily>().ToTable("StatisticRevenueDaily").HasKey(v => v.id);
            modelBuilder.Entity<SMSHistory>().ToTable("SMSHistory").HasKey(v => v.id);
            modelBuilder.Entity<MobileVersion>().ToTable("MobileVersion").HasKey(v => v.id);
            modelBuilder.Entity<PartnerFileContract>().ToTable("PartnerFileContract").HasKey(v => v.id);
            modelBuilder.Entity<Accessary>().ToTable("Accessary").HasKey(v => v.id);
            modelBuilder.Entity<Agency>().ToTable("Agency").HasKey(v => v.id);
            modelBuilder.Entity<AgencyAffiliateConfig>().ToTable("AgencyAffiliateConfig").HasKey(v => v.id);
            modelBuilder.Entity<BKCallbackRequestModel>().ToTable("BKCallbackRequest").HasKey(v => v.id);
            modelBuilder.Entity<BlueLinkCallbackRequestModel>().ToTable("BlueLinkCallbackRequest").HasKey(v => v.id);
            modelBuilder.Entity<SubServiceType>().ToTable("SubServiceType").HasKey(v => v.id);
            modelBuilder.Entity<ServiceTypeTag>().ToTable("ServiceTypeTag").HasKey(v => v.id);
            modelBuilder.Entity<ServiceType_ServiceTypeTag>().ToTable("ServiceType_ServiceTypeTag").HasKey(v => v.id);
            modelBuilder.Entity<CustomerPartnerRecent>().ToTable("CustomerPartnerRecent").HasKey(v => v.id);
            modelBuilder.Entity<ProductCurrentVersion>().ToTable("ProductCurrentVersion").HasKey(v => v.id);
            modelBuilder.Entity<ProductMenuComboCurrentVersion>().ToTable("ProductMenuComboCurrentVersion").HasKey(v => v.id);
            modelBuilder.Entity<CustomerPointHistory>().ToTable("CustomerPointHistory").HasKey(v => v.id);
            modelBuilder.Entity<Parrtner_ServiceTypeTag>().ToTable("Parrtner_ServiceTypeTag").HasKey(v => v.id);
            
            modelBuilder.Entity<BaoKimCollectionTransaction>().ToTable("BaoKimCollectionTransaction").HasKey(v => v.id);
            modelBuilder.Entity<BaoKimSettlementTransaction>().ToTable("BaoKimSettlementTransaction").HasKey(v => v.id);
            modelBuilder.Entity<Invoice>().ToTable("Invoice").HasKey(v => v.id);
            modelBuilder.Entity<PartnerInvoice>().ToTable("PartnerInvoice").HasKey(v => v.id);
            modelBuilder.Entity<InvoiceItem>().ToTable("InvoiceItem").HasKey(v => v.id);

            
            modelBuilder.Entity<Promotion>().ToTable("Promotion").HasKey(v => v.id);
            modelBuilder.Entity<Gift>().ToTable("Gift").HasKey(v => v.id);
            modelBuilder.Entity<Condition>().ToTable("Condition").HasKey(v => v.id);
            modelBuilder.Entity<ConditionGift>().ToTable("ConditionGift").HasKey(v => v.id);
            modelBuilder.Entity<PromotionUser>().ToTable("PromotionUser").HasKey(v => v.id);
            modelBuilder.Entity<RewardHistory>().ToTable("RewardHistory").HasKey(v => v.id);
            modelBuilder.Entity<TransactionForReward>().ToTable("TransactionForReward").HasKey(v => v.id);
            
            modelBuilder.Entity<Menu>().ToTable("Menu").HasKey(v => v.id);
            modelBuilder.Entity<MenuImage>().ToTable("MenuImage").HasKey(v => v.id);
            modelBuilder.Entity<Cart>().ToTable("Cart").HasKey(v => v.id);
            modelBuilder.Entity<CartItem>().ToTable("CartItem").HasKey(v => v.id);
            modelBuilder.Entity<Order>().ToTable("Order").HasKey(v => v.id);
            modelBuilder.Entity<OrderItem>().ToTable("OrderItem").HasKey(v => v.id);
            modelBuilder.Entity<OrderStatistic>().ToTable("OrderStatistic").HasKey(v => v.id);
            modelBuilder.Entity<ProductMenu>().ToTable("ProductMenu").HasKey(v => v.id);
            modelBuilder.Entity<ProductMenuGroup>().ToTable("ProductMenuGroup").HasKey(v => v.id);
            modelBuilder.Entity<ProductMenuCombo>().ToTable("ProductMenuCombo").HasKey(v => v.id);
            modelBuilder.Entity<Menu>().ToTable("Menu").HasKey(v => v.id);
            modelBuilder.Entity<ProductCurrentVersion>().ToTable("ProductCurrentVersion").HasKey(v => v.id);
            modelBuilder.Entity<ProductMenuComboCurrentVersion>().ToTable("ProductMenuComboCurrentVersion").HasKey(v => v.id);
            modelBuilder.Entity<ProductVersion>().ToTable("ProductVersion").HasKey(v => v.id);
            modelBuilder.Entity<InvoiceItem>().ToTable("InvoiceItem").HasKey(v => v.id);
            modelBuilder.Entity<TableMessage>().ToTable("TableMessage").HasKey(v => v.id);

            //Promotion
            modelBuilder.Entity<Promotion>(entity =>
            {
                entity.ToTable("Promotion");
                entity.HasKey(p => p.id);
                entity.Property(p => p.promotion_name).HasMaxLength(255).IsRequired();
                entity.Property(p => p.promotion_code).HasMaxLength(255).IsRequired();
            });

            // Cấu hình cho bảng Condition
            modelBuilder.Entity<Condition>(entity =>
            {
                entity.ToTable("Condition");
                entity.HasKey(c => c.id);
                entity.HasOne(c => c.Promotion)
                      .WithMany(p => p.Conditions)
                      .HasForeignKey(c => c.promotion_id);
                entity.HasOne(c => c.Gift)
                      .WithMany(g => g.Conditions)
                      .HasForeignKey(c => c.gift_id);
            });

            // Cấu hình cho bảng Gift
            modelBuilder.Entity<Gift>(entity =>
            {
                entity.ToTable("Gift");
                entity.HasKey(g => g.id);
                entity.Property(g => g.gift_name).HasMaxLength(255).IsRequired();
            });

            // Cấu hình cho bảng GiftHistory
            modelBuilder.Entity<GiftHistory>(entity =>
            {
                entity.ToTable("GiftHistory");
                entity.HasKey(gh => gh.id);
                entity.HasOne(gh => gh.Promotion)
                      .WithMany(p => p.GiftHistories)
                      .HasForeignKey(gh => gh.promotion_id);
                entity.HasOne(gh => gh.Condition)
                      .WithMany(c => c.GiftHistories)
                      .HasForeignKey(gh => gh.condition_id);
                entity.HasOne(gh => gh.Gift)
                      .WithMany()
                      .HasForeignKey(gh => gh.gift_id);
            });

            // Cấu hình cho bảng PhasePromotion
            modelBuilder.Entity<PhasePromotion>(entity =>
            {
                entity.ToTable("PhasePromotion");
                entity.HasKey(pp => pp.id);
                entity.HasOne(pp => pp.Promotion)
                      .WithMany(p => p.PhasePromotions)
                      .HasForeignKey(pp => pp.promotion_id);
            });

            // Cấu hình cho bảng PromotionUser
            modelBuilder.Entity<PromotionUser>(entity =>
            {
                entity.ToTable("PromotionUser");
                entity.HasKey(pu => pu.id);
                entity.HasOne(pu => pu.Condition)
                      .WithMany()
                      .HasForeignKey(pu => pu.condition_id);
                entity.HasOne(pu => pu.Promotion)
                      .WithMany()
                      .HasForeignKey(pu => pu.promotion_id);
            });
            modelBuilder.Entity<InvoiceTotalModel>().ToTable("InvoiceTotal").HasKey(v => v.id);
            modelBuilder.Entity<Invoice>().ToTable("Invoice").HasKey(v => v.id);
        }

        [DbFunction("CalculateDistance", "dbo")]    
        public static double CalculateDistance(double lat1, double long1, double lat2, double long2)
        {
            throw new NotImplementedException();
        }
    }
}
