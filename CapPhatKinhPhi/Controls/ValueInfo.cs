using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace CapPhatKinhPhi.Controls
{ 
public class ValueInfo
{

    private string _ID_DM;
    public string ID_DM
    {
        get { return _ID_DM; }
        set { _ID_DM = value; }
    }


    private string _MA_DM;
    public string MA_DM
    {
        get { return _MA_DM; }
        set { _MA_DM = value; }
    }


    private string _Ky_Hieu;
    public string Ky_Hieu
    {
        get { return _Ky_Hieu; }
        set { _Ky_Hieu = value; }
    }


    private string _Ten;
    public string Ten
    {
        get { return _Ten; }
        set { _Ten = value; }
    }


    private object _ParameterValue;
    public object ParameterValue
    {
        get { return _ParameterValue; }
        set { _ParameterValue = value; }
    }


    private object _Tu_Ngay;
    public object Tu_Ngay
    {
        get { return _Tu_Ngay; }
        set { _Tu_Ngay = value; }
    }



    private object _Den_Ngay;
    public object Den_Ngay
    {
        get { return _Den_Ngay; }
        set { _Den_Ngay = value; }
    }
}
}