﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace frmAddEmployeeType
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SPEntities3 : DbContext
    {
        public SPEntities3()
            : base("name=SPEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Access_Level> Access_Level { get; set; }
        public virtual DbSet<Audit_Create_Delete> Audit_Create_Delete { get; set; }
        public virtual DbSet<Audit_Log> Audit_Log { get; set; }
        public virtual DbSet<Audit_Update> Audit_Update { get; set; }
        public virtual DbSet<Backorder_Line> Backorder_Line { get; set; }
        public virtual DbSet<Backorder_Status> Backorder_Status { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Client_Account_Status> Client_Account_Status { get; set; }
        public virtual DbSet<Client_Purchase_Order> Client_Purchase_Order { get; set; }
        public virtual DbSet<Client_Purchase_Order_Line> Client_Purchase_Order_Line { get; set; }
        public virtual DbSet<Company_Information> Company_Information { get; set; }
        public virtual DbSet<Credit_Approval> Credit_Approval { get; set; }
        public virtual DbSet<Credit_Authorization> Credit_Authorization { get; set; }
        public virtual DbSet<Credit_Return> Credit_Return { get; set; }
        public virtual DbSet<Credit_Return_Line> Credit_Return_Line { get; set; }
        public virtual DbSet<Credit_Status> Credit_Status { get; set; }
        public virtual DbSet<Dispatch> Dispatches { get; set; }
        public virtual DbSet<Dispatch_Type> Dispatch_Type { get; set; }
        public virtual DbSet<Email_Notice_Template> Email_Notice_Template { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employee_Logsheet> Employee_Logsheet { get; set; }
        public virtual DbSet<Employee_Type> Employee_Type { get; set; }
        public virtual DbSet<Order_Unit_Price> Order_Unit_Price { get; set; }
        public virtual DbSet<Pack_Size> Pack_Size { get; set; }
        public virtual DbSet<Payment_Term> Payment_Term { get; set; }
        public virtual DbSet<pLength> pLengths { get; set; }
        public virtual DbSet<Ply> Plies { get; set; }
        public virtual DbSet<Postal_Code> Postal_Code { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Product_Brand> Product_Brand { get; set; }
        public virtual DbSet<Product_Image> Product_Image { get; set; }
        public virtual DbSet<Product_Type> Product_Type { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Purchase_Order_Status> Purchase_Order_Status { get; set; }
        public virtual DbSet<Reason_For_Return> Reason_For_Return { get; set; }
        public virtual DbSet<Refund_Line> Refund_Line { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Sale_Refund> Sale_Refund { get; set; }
        public virtual DbSet<Sales_Order_line> Sales_Order_line { get; set; }
        public virtual DbSet<Sales_Unit_Price> Sales_Unit_Price { get; set; }
        public virtual DbSet<Sheet> Sheets { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Supplier_Backorder> Supplier_Backorder { get; set; }
        public virtual DbSet<Supplier_Order> Supplier_Order { get; set; }
        public virtual DbSet<Supplier_Order_Line> Supplier_Order_Line { get; set; }
        public virtual DbSet<Supplier_Order_Status> Supplier_Order_Status { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<Vehicle_Status> Vehicle_Status { get; set; }
        public virtual DbSet<Width> Widths { get; set; }
    }
}
