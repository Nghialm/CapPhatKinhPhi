using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.CapPhatKinhPhi.Domain
{
    public partial class Info : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private string _Ma = String.Empty;
        private string _GiaTri = String.Empty;
        private string _MoTa = String.Empty;
		private int _TrangThai = 0;
		
		
		
        #endregion

        #region Constructors

        public Info() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_Ma);
			sb.Append(_GiaTri);
			sb.Append(_MoTa);
			sb.Append(_TrangThai);

            return sb.ToString().GetHashCode();
        }
		
		public Info Clone()
        {
            return (Info)this.MemberwiseClone();
        }
		
		public void SetProperty(Info des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_Ma = des.Ma;
			_GiaTri = des.GiaTri;
			_MoTa = des.MoTa;
			_TrangThai = des.TrangThai;
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
		
		public virtual string GiaTri
        {
            get { return _GiaTri; }
			set
			{
				OnGiaTriChanging();
				_GiaTri = value;
				OnGiaTriChanged();
			}
        }
		partial void OnGiaTriChanging();
		partial void OnGiaTriChanged();
		
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
		
		public virtual int TrangThai
        {
            get { return _TrangThai; }
			set
			{
				OnTrangThaiChanging();
				_TrangThai = value;
				OnTrangThaiChanged();
			}
        }
		partial void OnTrangThaiChanging();
		partial void OnTrangThaiChanged();
		
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
