using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.CapPhatKinhPhi.Domain
{
    public partial class VnsDmKhoanChi : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private string _Ma = String.Empty;
		private string _TenKhoanChi = String.Empty;
		private string _MoTa = String.Empty;
		
		
		
        #endregion

        #region Constructors

        public VnsDmKhoanChi() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_Ma);
			sb.Append(_TenKhoanChi);
			sb.Append(_MoTa);

            return sb.ToString().GetHashCode();
        }
		
		public VnsDmKhoanChi Clone()
        {
            return (VnsDmKhoanChi)this.MemberwiseClone();
        }
		
		public void SetProperty(VnsDmKhoanChi des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_Ma = des.Ma;
			_TenKhoanChi = des.TenKhoanChi;
			_MoTa = des.MoTa;
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
		
		public virtual string TenKhoanChi
        {
            get { return _TenKhoanChi; }
			set
			{
				OnTenKhoanChiChanging();
				_TenKhoanChi = value;
				OnTenKhoanChiChanged();
			}
        }
		partial void OnTenKhoanChiChanging();
		partial void OnTenKhoanChiChanged();
		
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
