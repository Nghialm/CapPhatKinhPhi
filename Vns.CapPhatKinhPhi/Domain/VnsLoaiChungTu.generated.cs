using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.CapPhatKinhPhi.Domain
{
    public partial class VnsLoaiChungTu : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private string _MaLoaiChungTu = String.Empty;
        private string _Ten = String.Empty;
		private int _LoaiPhieu = 0;
        private string _MaTkNo = String.Empty;
        private string _MaTkCo = String.Empty;
        private string _MoTa = String.Empty;
        private string _MauSoCt = String.Empty;
		
		
		
        #endregion

        #region Constructors

        public VnsLoaiChungTu() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_MaLoaiChungTu);
			sb.Append(_Ten);
			sb.Append(_LoaiPhieu);
			sb.Append(_MaTkNo);
			sb.Append(_MaTkCo);
			sb.Append(_MoTa);
			sb.Append(_MauSoCt);

            return sb.ToString().GetHashCode();
        }
		
		public VnsLoaiChungTu Clone()
        {
            return (VnsLoaiChungTu)this.MemberwiseClone();
        }
		
		public void SetProperty(VnsLoaiChungTu des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_MaLoaiChungTu = des.MaLoaiChungTu;
			_Ten = des.Ten;
			_LoaiPhieu = des.LoaiPhieu;
			_MaTkNo = des.MaTkNo;
			_MaTkCo = des.MaTkCo;
			_MoTa = des.MoTa;
			_MauSoCt = des.MauSoCt;
		}

        #endregion

        #region Properties

		public virtual string MaLoaiChungTu
        {
            get { return _MaLoaiChungTu; }
			set
			{
				OnMaLoaiChungTuChanging();
				_MaLoaiChungTu = value;
				OnMaLoaiChungTuChanged();
			}
        }
		partial void OnMaLoaiChungTuChanging();
		partial void OnMaLoaiChungTuChanged();
		
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
		
		public virtual int LoaiPhieu
        {
            get { return _LoaiPhieu; }
			set
			{
				OnLoaiPhieuChanging();
				_LoaiPhieu = value;
				OnLoaiPhieuChanged();
			}
        }
		partial void OnLoaiPhieuChanging();
		partial void OnLoaiPhieuChanged();
		
		public virtual string MaTkNo
        {
            get { return _MaTkNo; }
			set
			{
				OnMaTkNoChanging();
				_MaTkNo = value;
				OnMaTkNoChanged();
			}
        }
		partial void OnMaTkNoChanging();
		partial void OnMaTkNoChanged();
		
		public virtual string MaTkCo
        {
            get { return _MaTkCo; }
			set
			{
				OnMaTkCoChanging();
				_MaTkCo = value;
				OnMaTkCoChanged();
			}
        }
		partial void OnMaTkCoChanging();
		partial void OnMaTkCoChanged();
		
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
		
		public virtual string MauSoCt
        {
            get { return _MauSoCt; }
			set
			{
				OnMauSoCtChanging();
				_MauSoCt = value;
				OnMauSoCtChanged();
			}
        }
		partial void OnMauSoCtChanging();
		partial void OnMauSoCtChanged();
		
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
