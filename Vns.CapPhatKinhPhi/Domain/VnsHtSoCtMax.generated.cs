using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.CapPhatKinhPhi.Domain
{
    public partial class VnsHtSoCtMax : DomainObject<System.Guid>, INotifyPropertyChanged
    {
        #region Declarations

		
		private System.Guid _LoaichungtuId = new Guid();
		private int _SoChungtuMax = 0;
		private int _Thang = 0;
		private int _Nam = 0;
		
		
		
        #endregion

        #region Constructors

        public VnsHtSoCtMax() { }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            sb.Append(this.GetType().FullName);
			sb.Append(_LoaichungtuId);
			sb.Append(_SoChungtuMax);
			sb.Append(_Thang);
			sb.Append(_Nam);

            return sb.ToString().GetHashCode();
        }
		
		public VnsHtSoCtMax Clone()
        {
            return (VnsHtSoCtMax)this.MemberwiseClone();
        }
		
		public void SetProperty(VnsHtSoCtMax des)
		{
			//ID Field
			Id = des.Id;
			//Non ID Field
			_LoaichungtuId = des.LoaichungtuId;
			_SoChungtuMax = des.SoChungtuMax;
			_Thang = des.Thang;
			_Nam = des.Nam;
		}

        #endregion

        #region Properties

		public virtual System.Guid LoaichungtuId
        {
            get { return _LoaichungtuId; }
			set
			{
				OnLoaichungtuIdChanging();
				_LoaichungtuId = value;
				OnLoaichungtuIdChanged();
			}
        }
		partial void OnLoaichungtuIdChanging();
		partial void OnLoaichungtuIdChanged();
		
		public virtual int SoChungtuMax
        {
            get { return _SoChungtuMax; }
			set
			{
				OnSoChungtuMaxChanging();
				_SoChungtuMax = value;
				OnSoChungtuMaxChanged();
			}
        }
		partial void OnSoChungtuMaxChanging();
		partial void OnSoChungtuMaxChanged();
		
		public virtual int Thang
        {
            get { return _Thang; }
			set
			{
				OnThangChanging();
				_Thang = value;
				OnThangChanged();
			}
        }
		partial void OnThangChanging();
		partial void OnThangChanged();
		
		public virtual int Nam
        {
            get { return _Nam; }
			set
			{
				OnNamChanging();
				_Nam = value;
				OnNamChanged();
			}
        }
		partial void OnNamChanging();
		partial void OnNamChanged();
		
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
