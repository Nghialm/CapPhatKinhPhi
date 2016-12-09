using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.CapPhatKinhPhi.Domain
{
    public partial class VnsDmDonVi : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private string _Ma = String.Empty;
		private string _TenDonvi = String.Empty;
		private string _DiaChi = String.Empty;
		private string _SoTaiKhoan = String.Empty;
        private string _MaDvQhns = String.Empty;
        private string _MaTkCo = String.Empty;
        
        private System.Guid _NganHangId = new Guid();
        private System.Guid _NhomDonviId = new Guid();
		
		
		
        #endregion

        #region Constructors

        public VnsDmDonVi() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_Ma);
			sb.Append(_TenDonvi);
			sb.Append(_DiaChi);
			sb.Append(_SoTaiKhoan);
			sb.Append(_NganHangId);
            sb.Append(_NhomDonviId);
            sb.Append(_MaTkCo);
            
            return sb.ToString().GetHashCode();
        }
		
		public VnsDmDonVi Clone()
        {
            return (VnsDmDonVi)this.MemberwiseClone();
        }
		
		public void SetProperty(VnsDmDonVi des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_Ma = des.Ma;
			_TenDonvi = des.TenDonvi;
			_DiaChi = des.DiaChi;
			_SoTaiKhoan = des.SoTaiKhoan;
			_NganHangId = des.NganHangId;
            _NhomDonviId = des._NhomDonviId;
            _MaTkCo = des.MaTkCo;
		}

        #endregion

        #region Properties

		public virtual string Ma
        {
            get { return _Ma; }
			set
			{
				OnMaChanging();
				_Ma = value;
				OnMaChanged();
			}
        }
		partial void OnMaChanging();
		partial void OnMaChanged();
		
		public virtual string TenDonvi
        {
            get { return _TenDonvi; }
			set
			{
				OnTenDonviChanging();
				_TenDonvi = value;
				OnTenDonviChanged();
			}
        }
		partial void OnTenDonviChanging();
		partial void OnTenDonviChanged();
		
		public virtual string DiaChi
        {
            get { return _DiaChi; }
			set
			{
				OnDiaChiChanging();
				_DiaChi = value;
				OnDiaChiChanged();
			}
        }
		partial void OnDiaChiChanging();
		partial void OnDiaChiChanged();
		
		public virtual string SoTaiKhoan
        {
            get { return _SoTaiKhoan; }
			set
			{
				OnSoTaiKhoanChanging();
				_SoTaiKhoan = value;
				OnSoTaiKhoanChanged();
			}
        }
		partial void OnSoTaiKhoanChanging();
		partial void OnSoTaiKhoanChanged();
		
		public virtual System.Guid NganHangId
        {
            get { return _NganHangId; }
			set
			{
				OnNganHangIdChanging();
				_NganHangId = value;
				OnNganHangIdChanged();
			}
        }
		partial void OnNganHangIdChanging();
		partial void OnNganHangIdChanged();

        public virtual System.Guid NhomDonviId
        {
            get { return _NhomDonviId; }
            set
            {
                OnNhomDonviIdChanging();
                _NhomDonviId = value;
                OnNhomDonviIdChanged();
            }
        }
        partial void OnNhomDonviIdChanging();
        partial void OnNhomDonviIdChanged();

        public string MaDvQhns
        {
            get { return _MaDvQhns; }
            set { _MaDvQhns = value; }
        }

        partial void OnMaTkCoChanging();
        partial void OnMaTkCoChanged();

        public string MaTkCo
        {
            get { return _MaTkCo; }
            set { _MaTkCo = value; }
        }
        #endregion
		
		#region INotifyPropertyChanged
		public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
		#endregion
    }
}
