using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.CapPhatKinhPhi.Domain
{
    public partial class VnsDmNhomDonVi : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private string _Ma = String.Empty;
		private string _TenNhom = String.Empty;
		private string _MoTa = String.Empty;
		
		
		
        #endregion

        #region Constructors

        public VnsDmNhomDonVi() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_Ma);
			sb.Append(_TenNhom);
			sb.Append(_MoTa);

            return sb.ToString().GetHashCode();
        }
		
		public VnsDmNhomDonVi Clone()
        {
            return (VnsDmNhomDonVi)this.MemberwiseClone();
        }
		
		public void SetProperty(VnsDmNhomDonVi des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_Ma = des.Ma;
			_TenNhom = des.TenNhom;
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
		
		public virtual string TenNhom
        {
            get { return _TenNhom; }
			set
			{
				OnTenNhomChanging();
				_TenNhom = value;
				OnTenNhomChanged();
			}
        }
		partial void OnTenNhomChanging();
		partial void OnTenNhomChanged();
		
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
