using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.CapPhatKinhPhi.Domain
{
    public partial class VnsKhNganSach : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private System.DateTime _NgayCt = DateTime.Now;
        private System.DateTime _NgayKeHoach = DateTime.Now;
		private string _SoChungTu = String.Empty;
		private System.Guid _LoaiCt = new Guid();
        private String _MaCt = String.Empty;

        public String MaCt
        {
            get { return _MaCt; }
            set { _MaCt = value; }
        }
		private string _NoiDung = String.Empty;
		private System.Guid _DonViId = new Guid();
		private string _NguoiTao = String.Empty;
		private string _NguoiDuyet = String.Empty;

        private int _TrangThai = 0;
        public int TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }
        private Boolean _TuDong = false;
        public Boolean TuDong
        {
            get { return _TuDong; }
            set { _TuDong = value; }
        }
		
        #endregion

        #region Constructors

        public VnsKhNganSach() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_NgayCt);
			sb.Append(_NgayKeHoach);
			sb.Append(_SoChungTu);
			sb.Append(_LoaiCt);
			sb.Append(_NoiDung);
			sb.Append(_DonViId);
			sb.Append(_NguoiTao);
			sb.Append(_NguoiDuyet);

            return sb.ToString().GetHashCode();
        }
		
		public VnsKhNganSach Clone()
        {
            return (VnsKhNganSach)this.MemberwiseClone();
        }
		
		public void SetProperty(VnsKhNganSach des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_NgayCt = des.NgayCt;
			_NgayKeHoach = des.NgayKeHoach;
			_SoChungTu = des.SoChungTu;
			_LoaiCt = des.LoaiCt;
			_NoiDung = des.NoiDung;
			_DonViId = des.DonViId;
			_NguoiTao = des.NguoiTao;
			_NguoiDuyet = des.NguoiDuyet;
		}

        #endregion

        #region Properties

		public virtual System.DateTime NgayCt
        {
            get { return _NgayCt; }
			set
			{
				OnNgayCtChanging();
				_NgayCt = value;
				OnNgayCtChanged();
			}
        }
		partial void OnNgayCtChanging();
		partial void OnNgayCtChanged();
		
		public virtual System.DateTime NgayKeHoach
        {
            get { return _NgayKeHoach; }
			set
			{
				OnNgayKeHoachChanging();
				_NgayKeHoach = value;
				OnNgayKeHoachChanged();
			}
        }
		partial void OnNgayKeHoachChanging();
		partial void OnNgayKeHoachChanged();
		
		public virtual string SoChungTu
        {
            get { return _SoChungTu; }
			set
			{
				OnSoChungTuChanging();
				_SoChungTu = value;
				OnSoChungTuChanged();
			}
        }
		partial void OnSoChungTuChanging();
		partial void OnSoChungTuChanged();
		
		public virtual System.Guid LoaiCt
        {
            get { return _LoaiCt; }
			set
			{
				OnLoaiCtChanging();
				_LoaiCt = value;
				OnLoaiCtChanged();
			}
        }
		partial void OnLoaiCtChanging();
		partial void OnLoaiCtChanged();
		
		public virtual string NoiDung
        {
            get { return _NoiDung; }
			set
			{
				OnNoiDungChanging();
				_NoiDung = value;
				OnNoiDungChanged();
			}
        }
		partial void OnNoiDungChanging();
		partial void OnNoiDungChanged();
		
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
		
		public virtual string NguoiTao
        {
            get { return _NguoiTao; }
			set
			{
				OnNguoiTaoChanging();
				_NguoiTao = value;
				OnNguoiTaoChanged();
			}
        }
		partial void OnNguoiTaoChanging();
		partial void OnNguoiTaoChanged();
		
		public virtual string NguoiDuyet
        {
            get { return _NguoiDuyet; }
			set
			{
				OnNguoiDuyetChanging();
				_NguoiDuyet = value;
				OnNguoiDuyetChanged();
			}
        }
		partial void OnNguoiDuyetChanging();
		partial void OnNguoiDuyetChanged();
		
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
