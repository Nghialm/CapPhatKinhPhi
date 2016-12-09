using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.CapPhatKinhPhi.Domain
{
    public partial class VnsMaLoaiKhoan : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private string _Ma = String.Empty;
		private string _Ten = String.Empty;
		private System.Guid _IdCha = new Guid();
		private string _MaChuong = String.Empty;
		private string _MaHang = String.Empty;
		private string _MoTa = String.Empty;
        private int _ChiTiet = 0;
        private string _MaCha = String.Empty;

        public string MaCha
        {
            get { return _MaCha; }
            set { _MaCha = value; }
        }
        
		
		
        #endregion

        #region Constructors

        public VnsMaLoaiKhoan() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_Ma);
			sb.Append(_Ten);
			sb.Append(_IdCha);
			sb.Append(_MaChuong);
			sb.Append(_MaHang);
			sb.Append(_MoTa);
            sb.Append(_ChiTiet);

            return sb.ToString().GetHashCode();
        }
		
		public VnsMaLoaiKhoan Clone()
        {
            return (VnsMaLoaiKhoan)this.MemberwiseClone();
        }
		
		public void SetProperty(VnsMaLoaiKhoan des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_Ma = des.Ma;
			_Ten = des.Ten;
			_IdCha = des.IdCha;
			_MaChuong = des.MaChuong;
			_MaHang = des.MaHang;
			_MoTa = des.MoTa;
            _ChiTiet = des.ChiTiet;
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
		
		public virtual string Ten
        {
            get { return _Ten; }
			set
			{
				OnTenChanging();
				_Ten = value;
				OnTenChanged();
			}
        }
		partial void OnTenChanging();
		partial void OnTenChanged();
		
		public virtual System.Guid IdCha
        {
            get { return _IdCha; }
			set
			{
				OnIdChaChanging();
				_IdCha = value;
				OnIdChaChanged();
			}
        }
		partial void OnIdChaChanging();
		partial void OnIdChaChanged();
		
		public virtual string MaChuong
        {
            get { return _MaChuong; }
			set
			{
				OnMaChuongChanging();
				_MaChuong = value;
				OnMaChuongChanged();
			}
        }
		partial void OnMaChuongChanging();
		partial void OnMaChuongChanged();
		
		public virtual string MaHang
        {
            get { return _MaHang; }
			set
			{
				OnMaHangChanging();
				_MaHang = value;
				OnMaHangChanged();
			}
        }
		partial void OnMaHangChanging();
		partial void OnMaHangChanged();
		
		public virtual string MoTa
        {
            get { return _MoTa; }
			set
			{
				OnMoTaChanging();
				_MoTa = value;
				OnMoTaChanged();
			}
        }
		partial void OnMoTaChanging();
		partial void OnMoTaChanged();

        public virtual int ChiTiet
        {
            get { return _ChiTiet; }
            set { _ChiTiet = value; }
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
