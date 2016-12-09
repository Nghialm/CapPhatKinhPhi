using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.CapPhatKinhPhi.Domain
{
    public partial class VnsCtNganSach : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private System.Guid _IdKeHoach = new Guid();
		private string _MaChungTu = String.Empty;
		private System.Guid _LoaiKhoanId = new Guid();
		private System.Guid _DonViId = new Guid();
		private System.Guid _KhoanChiId = new Guid();
		private decimal _SoTien = 0;
		private string _DienGiai = String.Empty;
        private string _NoiDungCapPhat = String.Empty;

        public string NoiDungCapPhat
        {
            get { return _NoiDungCapPhat; }
            set { _NoiDungCapPhat = value; }
        }
		
		
        #endregion

        #region Constructors

        public VnsCtNganSach() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_IdKeHoach);
			sb.Append(_MaChungTu);
			sb.Append(_LoaiKhoanId);
			sb.Append(_DonViId);
			sb.Append(_KhoanChiId);
			sb.Append(_SoTien);
			sb.Append(_DienGiai);

            return sb.ToString().GetHashCode();
        }
		
		public VnsCtNganSach Clone()
        {
            return (VnsCtNganSach)this.MemberwiseClone();
        }
		
		public void SetProperty(VnsCtNganSach des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_IdKeHoach = des.IdKeHoach;
			_MaChungTu = des.MaChungTu;
			_LoaiKhoanId = des.LoaiKhoanId;
			_DonViId = des.DonViId;
			_KhoanChiId = des.KhoanChiId;
			_SoTien = des.SoTien;
			_DienGiai = des.DienGiai;
		}

        #endregion

        #region Properties

		public virtual System.Guid IdKeHoach
        {
            get { return _IdKeHoach; }
			set
			{
				OnIdKeHoachChanging();
				_IdKeHoach = value;
				OnIdKeHoachChanged();
			}
        }
		partial void OnIdKeHoachChanging();
		partial void OnIdKeHoachChanged();
		
		public virtual string MaChungTu
        {
            get { return _MaChungTu; }
			set
			{
				OnMaChungTuChanging();
				_MaChungTu = value;
				OnMaChungTuChanged();
			}
        }
		partial void OnMaChungTuChanging();
		partial void OnMaChungTuChanged();
		
		public virtual System.Guid LoaiKhoanId
        {
            get { return _LoaiKhoanId; }
			set
			{
				OnLoaiKhoanIdChanging();
				_LoaiKhoanId = value;
				OnLoaiKhoanIdChanged();
			}
        }
		partial void OnLoaiKhoanIdChanging();
		partial void OnLoaiKhoanIdChanged();
		
		public virtual System.Guid DonViId
        {
            get { return _DonViId; }
			set
			{
				OnDonViIdChanging();
				_DonViId = value;
				OnDonViIdChanged();
			}
        }
		partial void OnDonViIdChanging();
		partial void OnDonViIdChanged();
		
		public virtual System.Guid KhoanChiId
        {
            get { return _KhoanChiId; }
			set
			{
				OnKhoanChiIdChanging();
				_KhoanChiId = value;
				OnKhoanChiIdChanged();
			}
        }
		partial void OnKhoanChiIdChanging();
		partial void OnKhoanChiIdChanged();
		
		public virtual decimal SoTien
        {
            get { return _SoTien; }
			set
			{
				OnSoTienChanging();
				_SoTien = value;
				OnSoTienChanged();
			}
        }
		partial void OnSoTienChanging();
		partial void OnSoTienChanged();
		
		public virtual string DienGiai
        {
            get { return _DienGiai; }
			set
			{
				OnDienGiaiChanging();
				_DienGiai = value;
				OnDienGiaiChanged();
			}
        }
		partial void OnDienGiaiChanging();
		partial void OnDienGiaiChanged();
		
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
