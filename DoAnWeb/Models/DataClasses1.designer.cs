﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnWeb.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DB_LTGFASION")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDANHMUC(DANHMUC instance);
    partial void UpdateDANHMUC(DANHMUC instance);
    partial void DeleteDANHMUC(DANHMUC instance);
    partial void InsertTAIKHOAN(TAIKHOAN instance);
    partial void UpdateTAIKHOAN(TAIKHOAN instance);
    partial void DeleteTAIKHOAN(TAIKHOAN instance);
    partial void InsertGIOHANG(GIOHANG instance);
    partial void UpdateGIOHANG(GIOHANG instance);
    partial void DeleteGIOHANG(GIOHANG instance);
    partial void InsertLOAISANPHAM(LOAISANPHAM instance);
    partial void UpdateLOAISANPHAM(LOAISANPHAM instance);
    partial void DeleteLOAISANPHAM(LOAISANPHAM instance);
    partial void InsertSANPHAM(SANPHAM instance);
    partial void UpdateSANPHAM(SANPHAM instance);
    partial void DeleteSANPHAM(SANPHAM instance);
    partial void InsertTINTUC(TINTUC instance);
    partial void UpdateTINTUC(TINTUC instance);
    partial void DeleteTINTUC(TINTUC instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DB_LTGFASIONConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DANHMUC> DANHMUCs
		{
			get
			{
				return this.GetTable<DANHMUC>();
			}
		}
		
		public System.Data.Linq.Table<TAIKHOAN> TAIKHOANs
		{
			get
			{
				return this.GetTable<TAIKHOAN>();
			}
		}
		
		public System.Data.Linq.Table<GIOHANG> GIOHANGs
		{
			get
			{
				return this.GetTable<GIOHANG>();
			}
		}
		
		public System.Data.Linq.Table<LOAISANPHAM> LOAISANPHAMs
		{
			get
			{
				return this.GetTable<LOAISANPHAM>();
			}
		}
		
		public System.Data.Linq.Table<SANPHAM> SANPHAMs
		{
			get
			{
				return this.GetTable<SANPHAM>();
			}
		}
		
		public System.Data.Linq.Table<TINTUC> TINTUCs
		{
			get
			{
				return this.GetTable<TINTUC>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DANHMUC")]
	public partial class DANHMUC : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MADANHMUC;
		
		private string _TENDANHMUC;
		
		private EntitySet<SANPHAM> _SANPHAMs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMADANHMUCChanging(int value);
    partial void OnMADANHMUCChanged();
    partial void OnTENDANHMUCChanging(string value);
    partial void OnTENDANHMUCChanged();
    #endregion
		
		public DANHMUC()
		{
			this._SANPHAMs = new EntitySet<SANPHAM>(new Action<SANPHAM>(this.attach_SANPHAMs), new Action<SANPHAM>(this.detach_SANPHAMs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MADANHMUC", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MADANHMUC
		{
			get
			{
				return this._MADANHMUC;
			}
			set
			{
				if ((this._MADANHMUC != value))
				{
					this.OnMADANHMUCChanging(value);
					this.SendPropertyChanging();
					this._MADANHMUC = value;
					this.SendPropertyChanged("MADANHMUC");
					this.OnMADANHMUCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENDANHMUC", DbType="NVarChar(255)")]
		public string TENDANHMUC
		{
			get
			{
				return this._TENDANHMUC;
			}
			set
			{
				if ((this._TENDANHMUC != value))
				{
					this.OnTENDANHMUCChanging(value);
					this.SendPropertyChanging();
					this._TENDANHMUC = value;
					this.SendPropertyChanged("TENDANHMUC");
					this.OnTENDANHMUCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DANHMUC_SANPHAM", Storage="_SANPHAMs", ThisKey="MADANHMUC", OtherKey="MADANHMUC")]
		public EntitySet<SANPHAM> SANPHAMs
		{
			get
			{
				return this._SANPHAMs;
			}
			set
			{
				this._SANPHAMs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.DANHMUC = this;
		}
		
		private void detach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.DANHMUC = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TAIKHOAN")]
	public partial class TAIKHOAN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TENDN;
		
		private string _MATKHAU;
		
		private string _EMAIL;
		
		private EntitySet<GIOHANG> _GIOHANGs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTENDNChanging(string value);
    partial void OnTENDNChanged();
    partial void OnMATKHAUChanging(string value);
    partial void OnMATKHAUChanged();
    partial void OnEMAILChanging(string value);
    partial void OnEMAILChanged();
    #endregion
		
		public TAIKHOAN()
		{
			this._GIOHANGs = new EntitySet<GIOHANG>(new Action<GIOHANG>(this.attach_GIOHANGs), new Action<GIOHANG>(this.detach_GIOHANGs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENDN", DbType="NVarChar(255) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TENDN
		{
			get
			{
				return this._TENDN;
			}
			set
			{
				if ((this._TENDN != value))
				{
					this.OnTENDNChanging(value);
					this.SendPropertyChanging();
					this._TENDN = value;
					this.SendPropertyChanged("TENDN");
					this.OnTENDNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MATKHAU", DbType="NVarChar(255)")]
		public string MATKHAU
		{
			get
			{
				return this._MATKHAU;
			}
			set
			{
				if ((this._MATKHAU != value))
				{
					this.OnMATKHAUChanging(value);
					this.SendPropertyChanging();
					this._MATKHAU = value;
					this.SendPropertyChanged("MATKHAU");
					this.OnMATKHAUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMAIL", DbType="NVarChar(255)")]
		public string EMAIL
		{
			get
			{
				return this._EMAIL;
			}
			set
			{
				if ((this._EMAIL != value))
				{
					this.OnEMAILChanging(value);
					this.SendPropertyChanging();
					this._EMAIL = value;
					this.SendPropertyChanged("EMAIL");
					this.OnEMAILChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TAIKHOAN_GIOHANG", Storage="_GIOHANGs", ThisKey="TENDN", OtherKey="TENDN")]
		public EntitySet<GIOHANG> GIOHANGs
		{
			get
			{
				return this._GIOHANGs;
			}
			set
			{
				this._GIOHANGs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_GIOHANGs(GIOHANG entity)
		{
			this.SendPropertyChanging();
			entity.TAIKHOAN = this;
		}
		
		private void detach_GIOHANGs(GIOHANG entity)
		{
			this.SendPropertyChanging();
			entity.TAIKHOAN = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GIOHANG")]
	public partial class GIOHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _TENDN;
		
		private System.Nullable<int> _MASP;
		
		private System.Nullable<int> _SOLUONG;
		
		private System.Nullable<System.DateTime> _NGAYTHEM;
		
		private EntityRef<TAIKHOAN> _TAIKHOAN;
		
		private EntityRef<SANPHAM> _SANPHAM;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTENDNChanging(string value);
    partial void OnTENDNChanged();
    partial void OnMASPChanging(System.Nullable<int> value);
    partial void OnMASPChanged();
    partial void OnSOLUONGChanging(System.Nullable<int> value);
    partial void OnSOLUONGChanged();
    partial void OnNGAYTHEMChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYTHEMChanged();
    #endregion
		
		public GIOHANG()
		{
			this._TAIKHOAN = default(EntityRef<TAIKHOAN>);
			this._SANPHAM = default(EntityRef<SANPHAM>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENDN", DbType="NVarChar(255)")]
		public string TENDN
		{
			get
			{
				return this._TENDN;
			}
			set
			{
				if ((this._TENDN != value))
				{
					if (this._TAIKHOAN.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTENDNChanging(value);
					this.SendPropertyChanging();
					this._TENDN = value;
					this.SendPropertyChanged("TENDN");
					this.OnTENDNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MASP", DbType="Int")]
		public System.Nullable<int> MASP
		{
			get
			{
				return this._MASP;
			}
			set
			{
				if ((this._MASP != value))
				{
					if (this._SANPHAM.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMASPChanging(value);
					this.SendPropertyChanging();
					this._MASP = value;
					this.SendPropertyChanged("MASP");
					this.OnMASPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SOLUONG", DbType="Int")]
		public System.Nullable<int> SOLUONG
		{
			get
			{
				return this._SOLUONG;
			}
			set
			{
				if ((this._SOLUONG != value))
				{
					this.OnSOLUONGChanging(value);
					this.SendPropertyChanging();
					this._SOLUONG = value;
					this.SendPropertyChanged("SOLUONG");
					this.OnSOLUONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYTHEM", DbType="DateTime")]
		public System.Nullable<System.DateTime> NGAYTHEM
		{
			get
			{
				return this._NGAYTHEM;
			}
			set
			{
				if ((this._NGAYTHEM != value))
				{
					this.OnNGAYTHEMChanging(value);
					this.SendPropertyChanging();
					this._NGAYTHEM = value;
					this.SendPropertyChanged("NGAYTHEM");
					this.OnNGAYTHEMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TAIKHOAN_GIOHANG", Storage="_TAIKHOAN", ThisKey="TENDN", OtherKey="TENDN", IsForeignKey=true)]
		public TAIKHOAN TAIKHOAN
		{
			get
			{
				return this._TAIKHOAN.Entity;
			}
			set
			{
				TAIKHOAN previousValue = this._TAIKHOAN.Entity;
				if (((previousValue != value) 
							|| (this._TAIKHOAN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TAIKHOAN.Entity = null;
						previousValue.GIOHANGs.Remove(this);
					}
					this._TAIKHOAN.Entity = value;
					if ((value != null))
					{
						value.GIOHANGs.Add(this);
						this._TENDN = value.TENDN;
					}
					else
					{
						this._TENDN = default(string);
					}
					this.SendPropertyChanged("TAIKHOAN");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SANPHAM_GIOHANG", Storage="_SANPHAM", ThisKey="MASP", OtherKey="MASP", IsForeignKey=true)]
		public SANPHAM SANPHAM
		{
			get
			{
				return this._SANPHAM.Entity;
			}
			set
			{
				SANPHAM previousValue = this._SANPHAM.Entity;
				if (((previousValue != value) 
							|| (this._SANPHAM.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SANPHAM.Entity = null;
						previousValue.GIOHANGs.Remove(this);
					}
					this._SANPHAM.Entity = value;
					if ((value != null))
					{
						value.GIOHANGs.Add(this);
						this._MASP = value.MASP;
					}
					else
					{
						this._MASP = default(Nullable<int>);
					}
					this.SendPropertyChanged("SANPHAM");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LOAISANPHAM")]
	public partial class LOAISANPHAM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MALOAI;
		
		private string _TENLOAI;
		
		private EntitySet<SANPHAM> _SANPHAMs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMALOAIChanging(int value);
    partial void OnMALOAIChanged();
    partial void OnTENLOAIChanging(string value);
    partial void OnTENLOAIChanged();
    #endregion
		
		public LOAISANPHAM()
		{
			this._SANPHAMs = new EntitySet<SANPHAM>(new Action<SANPHAM>(this.attach_SANPHAMs), new Action<SANPHAM>(this.detach_SANPHAMs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MALOAI", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MALOAI
		{
			get
			{
				return this._MALOAI;
			}
			set
			{
				if ((this._MALOAI != value))
				{
					this.OnMALOAIChanging(value);
					this.SendPropertyChanging();
					this._MALOAI = value;
					this.SendPropertyChanged("MALOAI");
					this.OnMALOAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENLOAI", DbType="NVarChar(255)")]
		public string TENLOAI
		{
			get
			{
				return this._TENLOAI;
			}
			set
			{
				if ((this._TENLOAI != value))
				{
					this.OnTENLOAIChanging(value);
					this.SendPropertyChanging();
					this._TENLOAI = value;
					this.SendPropertyChanged("TENLOAI");
					this.OnTENLOAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAISANPHAM_SANPHAM", Storage="_SANPHAMs", ThisKey="MALOAI", OtherKey="MALOAI")]
		public EntitySet<SANPHAM> SANPHAMs
		{
			get
			{
				return this._SANPHAMs;
			}
			set
			{
				this._SANPHAMs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.LOAISANPHAM = this;
		}
		
		private void detach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.LOAISANPHAM = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SANPHAM")]
	public partial class SANPHAM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MASP;
		
		private string _TENSP;
		
		private System.Nullable<double> _GIA;
		
		private string _MOTA;
		
		private string _DUONGDAN;
		
		private System.Nullable<System.DateTime> _NGAYCAPNHAT;
		
		private System.Nullable<int> _SOLUONG;
		
		private System.Nullable<double> _UUDAI;
		
		private System.Nullable<int> _MALOAI;
		
		private System.Nullable<int> _MADANHMUC;
		
		private EntitySet<GIOHANG> _GIOHANGs;
		
		private EntityRef<DANHMUC> _DANHMUC;
		
		private EntityRef<LOAISANPHAM> _LOAISANPHAM;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMASPChanging(int value);
    partial void OnMASPChanged();
    partial void OnTENSPChanging(string value);
    partial void OnTENSPChanged();
    partial void OnGIAChanging(System.Nullable<double> value);
    partial void OnGIAChanged();
    partial void OnMOTAChanging(string value);
    partial void OnMOTAChanged();
    partial void OnDUONGDANChanging(string value);
    partial void OnDUONGDANChanged();
    partial void OnNGAYCAPNHATChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYCAPNHATChanged();
    partial void OnSOLUONGChanging(System.Nullable<int> value);
    partial void OnSOLUONGChanged();
    partial void OnUUDAIChanging(System.Nullable<double> value);
    partial void OnUUDAIChanged();
    partial void OnMALOAIChanging(System.Nullable<int> value);
    partial void OnMALOAIChanged();
    partial void OnMADANHMUCChanging(System.Nullable<int> value);
    partial void OnMADANHMUCChanged();
    #endregion
		
		public SANPHAM()
		{
			this._GIOHANGs = new EntitySet<GIOHANG>(new Action<GIOHANG>(this.attach_GIOHANGs), new Action<GIOHANG>(this.detach_GIOHANGs));
			this._DANHMUC = default(EntityRef<DANHMUC>);
			this._LOAISANPHAM = default(EntityRef<LOAISANPHAM>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MASP", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MASP
		{
			get
			{
				return this._MASP;
			}
			set
			{
				if ((this._MASP != value))
				{
					this.OnMASPChanging(value);
					this.SendPropertyChanging();
					this._MASP = value;
					this.SendPropertyChanged("MASP");
					this.OnMASPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENSP", DbType="NVarChar(50)")]
		public string TENSP
		{
			get
			{
				return this._TENSP;
			}
			set
			{
				if ((this._TENSP != value))
				{
					this.OnTENSPChanging(value);
					this.SendPropertyChanging();
					this._TENSP = value;
					this.SendPropertyChanged("TENSP");
					this.OnTENSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GIA", DbType="Float")]
		public System.Nullable<double> GIA
		{
			get
			{
				return this._GIA;
			}
			set
			{
				if ((this._GIA != value))
				{
					this.OnGIAChanging(value);
					this.SendPropertyChanging();
					this._GIA = value;
					this.SendPropertyChanged("GIA");
					this.OnGIAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MOTA", DbType="NVarChar(50)")]
		public string MOTA
		{
			get
			{
				return this._MOTA;
			}
			set
			{
				if ((this._MOTA != value))
				{
					this.OnMOTAChanging(value);
					this.SendPropertyChanging();
					this._MOTA = value;
					this.SendPropertyChanged("MOTA");
					this.OnMOTAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DUONGDAN", DbType="NVarChar(50)")]
		public string DUONGDAN
		{
			get
			{
				return this._DUONGDAN;
			}
			set
			{
				if ((this._DUONGDAN != value))
				{
					this.OnDUONGDANChanging(value);
					this.SendPropertyChanging();
					this._DUONGDAN = value;
					this.SendPropertyChanged("DUONGDAN");
					this.OnDUONGDANChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYCAPNHAT", DbType="Date")]
		public System.Nullable<System.DateTime> NGAYCAPNHAT
		{
			get
			{
				return this._NGAYCAPNHAT;
			}
			set
			{
				if ((this._NGAYCAPNHAT != value))
				{
					this.OnNGAYCAPNHATChanging(value);
					this.SendPropertyChanging();
					this._NGAYCAPNHAT = value;
					this.SendPropertyChanged("NGAYCAPNHAT");
					this.OnNGAYCAPNHATChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SOLUONG", DbType="Int")]
		public System.Nullable<int> SOLUONG
		{
			get
			{
				return this._SOLUONG;
			}
			set
			{
				if ((this._SOLUONG != value))
				{
					this.OnSOLUONGChanging(value);
					this.SendPropertyChanging();
					this._SOLUONG = value;
					this.SendPropertyChanged("SOLUONG");
					this.OnSOLUONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UUDAI", DbType="Float")]
		public System.Nullable<double> UUDAI
		{
			get
			{
				return this._UUDAI;
			}
			set
			{
				if ((this._UUDAI != value))
				{
					this.OnUUDAIChanging(value);
					this.SendPropertyChanging();
					this._UUDAI = value;
					this.SendPropertyChanged("UUDAI");
					this.OnUUDAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MALOAI", DbType="Int")]
		public System.Nullable<int> MALOAI
		{
			get
			{
				return this._MALOAI;
			}
			set
			{
				if ((this._MALOAI != value))
				{
					if (this._LOAISANPHAM.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMALOAIChanging(value);
					this.SendPropertyChanging();
					this._MALOAI = value;
					this.SendPropertyChanged("MALOAI");
					this.OnMALOAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MADANHMUC", DbType="Int")]
		public System.Nullable<int> MADANHMUC
		{
			get
			{
				return this._MADANHMUC;
			}
			set
			{
				if ((this._MADANHMUC != value))
				{
					if (this._DANHMUC.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMADANHMUCChanging(value);
					this.SendPropertyChanging();
					this._MADANHMUC = value;
					this.SendPropertyChanged("MADANHMUC");
					this.OnMADANHMUCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SANPHAM_GIOHANG", Storage="_GIOHANGs", ThisKey="MASP", OtherKey="MASP")]
		public EntitySet<GIOHANG> GIOHANGs
		{
			get
			{
				return this._GIOHANGs;
			}
			set
			{
				this._GIOHANGs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DANHMUC_SANPHAM", Storage="_DANHMUC", ThisKey="MADANHMUC", OtherKey="MADANHMUC", IsForeignKey=true)]
		public DANHMUC DANHMUC
		{
			get
			{
				return this._DANHMUC.Entity;
			}
			set
			{
				DANHMUC previousValue = this._DANHMUC.Entity;
				if (((previousValue != value) 
							|| (this._DANHMUC.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DANHMUC.Entity = null;
						previousValue.SANPHAMs.Remove(this);
					}
					this._DANHMUC.Entity = value;
					if ((value != null))
					{
						value.SANPHAMs.Add(this);
						this._MADANHMUC = value.MADANHMUC;
					}
					else
					{
						this._MADANHMUC = default(Nullable<int>);
					}
					this.SendPropertyChanged("DANHMUC");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAISANPHAM_SANPHAM", Storage="_LOAISANPHAM", ThisKey="MALOAI", OtherKey="MALOAI", IsForeignKey=true)]
		public LOAISANPHAM LOAISANPHAM
		{
			get
			{
				return this._LOAISANPHAM.Entity;
			}
			set
			{
				LOAISANPHAM previousValue = this._LOAISANPHAM.Entity;
				if (((previousValue != value) 
							|| (this._LOAISANPHAM.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LOAISANPHAM.Entity = null;
						previousValue.SANPHAMs.Remove(this);
					}
					this._LOAISANPHAM.Entity = value;
					if ((value != null))
					{
						value.SANPHAMs.Add(this);
						this._MALOAI = value.MALOAI;
					}
					else
					{
						this._MALOAI = default(Nullable<int>);
					}
					this.SendPropertyChanged("LOAISANPHAM");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_GIOHANGs(GIOHANG entity)
		{
			this.SendPropertyChanging();
			entity.SANPHAM = this;
		}
		
		private void detach_GIOHANGs(GIOHANG entity)
		{
			this.SendPropertyChanging();
			entity.SANPHAM = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TINTUC")]
	public partial class TINTUC : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MATINTUC;
		
		private string _TIEUDE;
		
		private string _NOIDUNG;
		
		private System.DateTime _NGAYDANG;
		
		private string _DUONGDAN;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMATINTUCChanging(int value);
    partial void OnMATINTUCChanged();
    partial void OnTIEUDEChanging(string value);
    partial void OnTIEUDEChanged();
    partial void OnNOIDUNGChanging(string value);
    partial void OnNOIDUNGChanged();
    partial void OnNGAYDANGChanging(System.DateTime value);
    partial void OnNGAYDANGChanged();
    partial void OnDUONGDANChanging(string value);
    partial void OnDUONGDANChanged();
    #endregion
		
		public TINTUC()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MATINTUC", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MATINTUC
		{
			get
			{
				return this._MATINTUC;
			}
			set
			{
				if ((this._MATINTUC != value))
				{
					this.OnMATINTUCChanging(value);
					this.SendPropertyChanging();
					this._MATINTUC = value;
					this.SendPropertyChanged("MATINTUC");
					this.OnMATINTUCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TIEUDE", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string TIEUDE
		{
			get
			{
				return this._TIEUDE;
			}
			set
			{
				if ((this._TIEUDE != value))
				{
					this.OnTIEUDEChanging(value);
					this.SendPropertyChanging();
					this._TIEUDE = value;
					this.SendPropertyChanged("TIEUDE");
					this.OnTIEUDEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOIDUNG", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string NOIDUNG
		{
			get
			{
				return this._NOIDUNG;
			}
			set
			{
				if ((this._NOIDUNG != value))
				{
					this.OnNOIDUNGChanging(value);
					this.SendPropertyChanging();
					this._NOIDUNG = value;
					this.SendPropertyChanged("NOIDUNG");
					this.OnNOIDUNGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYDANG", DbType="DateTime NOT NULL")]
		public System.DateTime NGAYDANG
		{
			get
			{
				return this._NGAYDANG;
			}
			set
			{
				if ((this._NGAYDANG != value))
				{
					this.OnNGAYDANGChanging(value);
					this.SendPropertyChanging();
					this._NGAYDANG = value;
					this.SendPropertyChanged("NGAYDANG");
					this.OnNGAYDANGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DUONGDAN", DbType="NVarChar(50)")]
		public string DUONGDAN
		{
			get
			{
				return this._DUONGDAN;
			}
			set
			{
				if ((this._DUONGDAN != value))
				{
					this.OnDUONGDANChanging(value);
					this.SendPropertyChanging();
					this._DUONGDAN = value;
					this.SendPropertyChanged("DUONGDAN");
					this.OnDUONGDANChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591