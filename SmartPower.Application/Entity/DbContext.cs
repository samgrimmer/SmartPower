using Microsoft.EntityFrameworkCore;
using SmartPower.Application.Entity.Model;

namespace SmartPower.Application.Entity
{
    public partial class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext() { }

        public DbContext(DbContextOptions<DbContext> options) : base(options) { }

        public virtual DbSet<TReversalsBulkList> TReversalsBulkLists { get; set; }
        public virtual DbSet<TInvoice> TInvoices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // TODO : remove
                optionsBuilder.UseSqlServer("Server=.\\;Database=Master_DB_DEMO;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<TReversalsBulkList>(entity =>
            {
                entity.HasKey(e => e.RevId);

                entity.ToTable("tReversals_Bulk_List");

                entity.Property(e => e.RevId).HasColumnName("Rev_ID");

                entity.Property(e => e.NewSpInvNumber).HasColumnName("New_SpInvNumber");

                entity.Property(e => e.OrgSpinvNumber).HasColumnName("Org_SPInvNumber");

                entity.Property(e => e.RevResults)
                    .HasMaxLength(100)
                    .HasColumnName("Rev_Results");

                entity.Property(e => e.RevStatus)
                    .HasMaxLength(100)
                    .HasColumnName("Rev_Status");

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<TInvoice>(entity =>
            {
                entity.HasKey(e => e.SpinvNumber);

                entity.ToTable("tInvoices");

                entity.Property(e => e.SpinvNumber).HasColumnName("SPInvNumber");

                entity.Property(e => e.AcadjFactor)
                    .HasColumnName("ACAdjFactor")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AccountNo).HasMaxLength(200);

                entity.Property(e => e.ApplySitePpd)
                    .HasColumnName("Apply_Site_PPD")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ArchiveDate).HasColumnType("date");

                entity.Property(e => e.ClientCode).HasMaxLength(10);

                entity.Property(e => e.CostsFees).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostsNetwork).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostsUsage).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreditInv).HasDefaultValueSql("((0))");

                entity.Property(e => e.EdiId).HasColumnName("EDI_ID");

                entity.Property(e => e.FixedKva)
                    .HasColumnName("FixedKVA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GstFreeCharges).HasColumnName("GST_Free_Charges");

                entity.Property(e => e.InvAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvAmountExGst)
                    .HasColumnType("money")
                    .HasColumnName("InvAmountExGST");

                entity.Property(e => e.InvAmountGst)
                    .HasColumnType("money")
                    .HasColumnName("InvAmountGST");

                entity.Property(e => e.InvAmountSoa)
                    .HasColumnName("InvAmountSOA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvAmountToPay)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvAmountToPayExGst)
                    .HasColumnType("money")
                    .HasColumnName("InvAmountToPayExGST");

                entity.Property(e => e.InvAmountToPayGst)
                    .HasColumnType("money")
                    .HasColumnName("InvAmountToPayGST");

                entity.Property(e => e.InvArchived)
                    .HasColumnName("Inv_Archived")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvDate).HasColumnType("date");

                entity.Property(e => e.InvDiscount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvDiscountExGst)
                    .HasColumnType("money")
                    .HasColumnName("InvDiscountExGST");

                entity.Property(e => e.InvDiscountGst)
                    .HasColumnType("money")
                    .HasColumnName("InvDiscountGST");

                entity.Property(e => e.InvDueDate).HasColumnType("date");

                entity.Property(e => e.InvEndDate).HasColumnType("date");

                entity.Property(e => e.InvEnteredDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InvGst)
                    .HasColumnType("money")
                    .HasColumnName("InvGST")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvLinesArchived).HasColumnName("Inv_Lines_Archived");

                entity.Property(e => e.InvNoPayfile).HasColumnName("InvNo_Payfile");

                entity.Property(e => e.InvNotes).HasMaxLength(255);

                entity.Property(e => e.InvNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InvOpenBalType).HasMaxLength(10);

                entity.Property(e => e.InvOpeningBalance)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvStartDate).HasColumnType("date");

                entity.Property(e => e.InvSubTotal)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvTotal)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Losses).HasDefaultValueSql("((0))");

                entity.Property(e => e.NtwkFixed).HasDefaultValueSql("((0))");

                entity.Property(e => e.ObGst)
                    .HasColumnName("OB_GST")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ObGstFree)
                    .HasColumnName("OB_GST_Free")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Obnotes)
                    .HasMaxLength(255)
                    .HasColumnName("OBNotes");

                entity.Property(e => e.OpeningBalanceExGst)
                    .HasColumnType("money")
                    .HasColumnName("OpeningBalanceExGST");

                entity.Property(e => e.OpeningBalanceGst)
                    .HasColumnType("money")
                    .HasColumnName("OpeningBalanceGST");

                entity.Property(e => e.OrgId).HasColumnName("Org_ID");

                entity.Property(e => e.ParentAccNum)
                    .HasMaxLength(255)
                    .HasColumnName("Parent_Acc_Num");

                entity.Property(e => e.ParentSpin).HasColumnName("Parent_SPIN");

                entity.Property(e => e.PdfInvAmountToPay)
                    .HasColumnType("money")
                    .HasColumnName("PDF_InvAmountToPay");

                entity.Property(e => e.PpdGst)
                    .HasColumnName("PPD_GST")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PpdGstFree)
                    .HasColumnName("PPD_GST_Free")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PpdIgnoreSiteDiscount)
                    .HasColumnName("PPD_Ignore_Site_Discount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReadTypeCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'U')");

                entity.Property(e => e.RetailerCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SpinvNumberOrig).HasColumnName("SPInvNumberOrig");

                entity.Property(e => e.Split).HasColumnName("Split%");

                entity.Property(e => e.SpotRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatementNumber).HasMaxLength(255);

                entity.Property(e => e.SysInvoicesTimestamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("Sys_Invoices_Timestamp");

                entity.Property(e => e.UnitTotal).HasColumnName("Unit_Total");
            });
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}