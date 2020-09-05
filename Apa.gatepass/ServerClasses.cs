using System;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ServerClasses
{

    [SoapType(XmlNamespace = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses/ServerClasses%2C%20Version%3D1.0.0.0%2C%20Culture%3Dneutral%2C%20PublicKeyToken%3Dnull", XmlTypeNamespace = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses/ServerClasses%2C%20Version%3D1.0.0.0%2C%20Culture%3Dneutral%2C%20PublicKeyToken%3Dnull")]
    [ComVisible(true)]
    public class Customer : AllFunctions
    {
        [SoapMethod(SoapAction = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses.Customer/ServerClasses#TEST")]
        public System.Data.DataTable TEST(String str)
        {
            return ((Customer)_tp).TEST(str);
        }
        [SoapMethod(SoapAction = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses.Customer/ServerClasses#Suit")]
        public OutputDatas Suit(Byte[] inputDatas)
        {
            try
            {
                return ((Customer) _tp).Suit(inputDatas);
            }
            catch
            {
               
                return null;
            }
        }
    }

    [SoapType(XmlNamespace = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses/ServerClasses%2C%20Version%3D1.0.0.0%2C%20Culture%3Dneutral%2C%20PublicKeyToken%3Dnull", XmlTypeNamespace = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses/ServerClasses%2C%20Version%3D1.0.0.0%2C%20Culture%3Dneutral%2C%20PublicKeyToken%3Dnull")]
    [ComVisible(true)]
    public class AllFunctions : OutputDatas
    {
        [SoapMethod(SoapAction = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses.AllFunctions/aorc.gatepass#test")]
        public String test()
        {
            return ((AllFunctions)_tp).test();
        }
        [SoapMethod(SoapAction = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses.AllFunctions/aorc.gatepass#exceptor")]
        public void exceptor(System.Exception Ex, String ClassName, String[] FarsiMessage)
        {
            ((AllFunctions)_tp).exceptor(Ex, ClassName, FarsiMessage);
        }
        [SoapMethod(SoapAction = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses.AllFunctions/aorc.gatepass#exceptor")]
        public void exceptor()
        {
            ((AllFunctions)_tp).exceptor();
        }
        [SoapMethod(SoapAction = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses.AllFunctions/aorc.gatepass#exceptor")]
        public void exceptor(String ClassName, String[] FarsiMessage)
        {
            ((AllFunctions)_tp).exceptor(ClassName, FarsiMessage);
        }

    	[Serializable,
    	 SoapType(
    	 	XmlNamespace =
    	 		@"http://schemas.microsoft.com/clr/nsassem/ServerClasses/ServerClasses%2C%20Version%3D1.0.0.0%2C%20Culture%3Dneutral%2C%20PublicKeyToken%3Dnull"
    	 	,
    	 	XmlTypeNamespace =
    	 		@"http://schemas.microsoft.com/clr/nsassem/ServerClasses/ServerClasses%2C%20Version%3D1.0.0.0%2C%20Culture%3Dneutral%2C%20PublicKeyToken%3Dnull"
    	 	)]
    	public enum _StatusPack : int
    	{
    		Create = 0,
    		Request = 1,
    		Confirm = 2,
    		NoConfirm = 3,
    		Passage = 4,
    		NoPassage = 5,
    		Expired = 6,
    		Print = 7,
    		MultiyPrint = 8,
    	}

    	[Serializable, SoapType(XmlNamespace = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses/ServerClasses%2C%20Version%3D1.0.0.0%2C%20Culture%3Dneutral%2C%20PublicKeyToken%3Dnull", XmlTypeNamespace = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses/ServerClasses%2C%20Version%3D1.0.0.0%2C%20Culture%3Dneutral%2C%20PublicKeyToken%3Dnull")]
        public enum _IdData : int
        {
            IdMethod = 0,
            Event_ObjId = 1,
            Event_OperId = 2,
            Event_MethodName = 3,
            Event_Description = 4,
            Event_ComputerName = 5,
            Event_IpAddress = 6,
            Event_IsSuccess = 7,
            Event_ERRSideClient = 8,
            Event_Message = 9,
            Operator_ID = 10,
            Operator_BaridId = 11,
            Operator_Tellphone1 = 12,
            Operator_Tellphone2 = 13,
            Operator_Hidden = 14,
            Operator_Active = 15,
            Sign_Allowed = 16,
            Sign_Shape = 17,
            Sign_DateStart = 18,
            Sign_DateExpire = 19,
            Group_Name = 20,
            Group_Description = 21,
            Group_IsActive = 22,
            Group_ID = 23,
            Group_ListRights = 24,
            Office_ID = 25,
            Office_ParentId = 26,
            Office_Active = 27,
            Office_Name = 28,
            Office_MonthlyGPAllowed = 29,
            Office_DailyGPAllowed = 30,
            Office_Description = 31,
            Office_Phone1 = 32,
            Office_Phone2 = 33,
            OfficeOperators_Id = 34,
            Agreement_ID = 35,
            Agreement_Number = 36,
            Agreement_Title = 37,
            Agreement_Company = 38,
            Agreement_StartDate = 39,
            Agreement_StartDate2 = 40,
            Agreement_EndDate = 41,
            Agreement_EndDate2 = 42,
            Agreement_IsActive = 43,
            Agreement_AgentName = 44,
            Agreement_AgentPhone = 45,
            Agreement_Description = 46,
            TravelArea_Id = 47,
            TravelArea_Name = 48,
            TravelArea_Description = 49,
            TravelArea_ParentId = 50,
            TravelArea_Hidden = 51,
            Vehicle_ID = 52,
            Vehicle_number = 53,
            vehicle_Name = 54,
            vehicle_Color = 55,
            Vehicle_Model = 56,
            VehicleType_ID = 57,
            VehicleType_Name = 58,
            VehicleType_Desc = 59,
            VehicleType_Hidden = 60,
            BlackList_ID = 61,
            BlackList_DateTime = 62,
            BlackList_isBlack = 63,
            BlackList_Desc = 64,
            BLReason_ID = 65,
            BLReason_Type = 66,
            BLReason_Desc = 67,
            BLReason_Hidden = 68,
            package_Id = 69,
            Package_StartDate = 70,
            Package_StartDate2 = 71,
            Package_EndDate = 72,
            Package_EndDate2 = 73,
            Package_OperIdRequest = 74,
            Package_OperIdConfirm = 75,
            Package_OperIdPassage = 76,
            Package_IsExpired = 77,
            Package_Description = 78,
            TypePack_Id = 79,
            Gatepass_ID = 80,
            GatePass_IntPrint = 81,
            Package_CollectionGps = 82,
            Person_IsBlackTemp = 83, 
            Person_ID = 84,
            Person_NationalCode = 85,
            Person_IdentifyCode = 86,
            Person_Name = 87,
            Person_Surname = 88,
            Person_FatherName = 89,
            Person_BirthCity = 90,
            Person_RegisterCity = 91,
            Person_BirthDate = 92,
            Person_Phone1 = 93,
            Person_Phone2 = 94,
            Person_Nationality = 95,
            Person_LicenseDriverCode = 96,
            Person_Picture = 97,
            Person_HaveForm = 98,
            Person_isWoman = 99,
            Person_RegisterCode=100,
            OffOperValue_Id = 101,
            Agreement_ManagerName = 102,
            Agreement_ManagerTell = 103,
            Agreement_IsIndustrial = 104,
            Agreement_Adress = 105,
            Agreement_LabelIsIndustrial = 106,
            Person_LabelIsWoman = 107 ,
            Operator_Name = 108 ,
            Package_Status = 109,
            Person_SmartFind = 110,
			Vehicle_IsCompany = 111,
			Person_Temp = 112,
			Agreement_CountCars = 113,
			Package_Shift = 114 ,
			PagePrints_Serial = 115,
			Vehicle_Temp = 116,
			GatePass_Events = 117,
			Package_Events = 118,
			City_Id = 119,
			City_Name =120,
			Nationality_Id =121,
			Nationality_Name =122,
			Package_GatesIdCombo=123 ,
			Person_SecureFormDate=124,
			Package_PlacesIdCombo=125,
            TypePlates_Id=126,
            TypePlates_Desc=127,
            requstActionLimited = 128,
            Group_OffOper_ListGroupsId=129,
            statePackForView = 130,
            GpPersonCarList = 131,
            EsiMiniGate_Id = 132,
            EsiMiniGate_Label = 133,
            EsiMiniGate_TimeRefresh =134,
            MiniGateMainEsiMode_Id=135,
            MiniGateWayEsiMode_Id=136,
            OUTMiniGateWayEsiMode_Id=137,

        }

        [Serializable, SoapType(XmlNamespace = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses/ServerClasses%2C%20Version%3D1.0.0.0%2C%20Culture%3Dneutral%2C%20PublicKeyToken%3Dnull", XmlTypeNamespace = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses/ServerClasses%2C%20Version%3D1.0.0.0%2C%20Culture%3Dneutral%2C%20PublicKeyToken%3Dnull")]
        public enum _IdMethod : int
        {
            testTable = 0,
            ClsAgreements_insert = 1,
            ClsAgreements_update = 2,
            ClsAgreements_delete = 3,
            ClsBlack_BL_insert = 4,
            ClsBlack_BLR_insert = 5,
            ClsBlack_BLR_update = 6,
            ClsBlack_BLR_delete = 7,
            ClsGroups_insert = 8,
            ClsGroups_update = 9,
            ClsGroups_delete = 10,
            ClsOffice_update = 11,
            ClsOffice_delete = 12,
            ClsOffice_insert = 13,
            ClsOffOper_Create = 14,
            ClsOffOper_Delete = 15,
            ClsOffOper_Update = 16,
            ClsOffOper_MyOffOperId = 17,
            ClsOperators_insert = 18,
            ClsOperators_delete = 19,
            ClsOperators_setTest = 20,
            ClsOperators_upDate = 21,
            ClsOperators_signInsert = 22,
            ClsOperators_signDelete = 23,
            ClsOperators_signUpdate = 24,
            ClsPacksGps_updatePackGps = 25,
            ClsPacksGps_insertPackGps = 26,
            ClsPacksGps_PrintedGP = 27,
            ClsPacksGps_RequestPrintGP = 28,
            ClsPacksGps_confirm = 29,
            ClsPacksGps_passage = 30,
            ClsPacksGps_FreePrintGP = 31,
            ClsPacksGps_PrintingGp = 32,
            ClsPersons_insert = 33,
            ClsPersons_delete = 34,
            ClsPersons_update = 35,
            ClsTravelAreas_insert = 36,
            ClsTravelAreas_update = 37,
            ClsVehicles_insert = 38,
            ClsVehicles_insert_Type = 39,
            ClsVehicles_update = 40,
            ClsVehicles_update_Type = 41,
            View_groups = 42,
            View_rights = 43,
            View_offices = 44,
            View_officeDetail = 45,
            View_operators = 46,
            View_operatorDetail = 47,
            View_agreements = 48,
            View_agreementDetail = 49,
            View_vehicles = 50,
            View_vehiclesType = 51,
            View_vehicleDetail = 52,
            View_travelAreas = 53,
            View_travelAreaDetail = 54,
            View_gatePasses = 55,
            View_gatePasseDetail = 56,
            View_packages = 57,
            View_packageDetail = 58,
            View_persons = 59,
            View_personDetail = 60,
            View_bLreasons = 61,
            View_bLreasonDetail = 62,
            View_blackLists = 63,
            View_blackListDetail = 64,
            ClsAgreements_HowManayCarsInAgree = 65,
            ClsGlobalSetting_update = 66,
            ClsGlobalSetting_View = 67,
            ClsPacksGps_ExpireGp = 68,
            ClsLocations_City_insert = 69,
            ClsLocations_Nationality_insert = 70,
            View_Cities = 71,
            View_Nationalities = 72,
            View_Gates = 73,
            View_Places = 74,
            MyConfirmers = 75,
            ClsGlobalSetting_AllowPrintSign = 76,
            ReportGP = 77,
            ReportInOut = 78,
            vehiclesListPersons = 79,
            ClsPersons_SecureManualUpdate = 80,
            FindJustArchive = 81,
            UpdateTag = 82,
            MyTypesPack = 83,
            ClsPacksGps_RegisterCards = 84,
            EsiContTestHard = 85,
            EsiContCurrentState = 86,
            EsiContTestNet= 87,
            EsiContSetNewMode=88,
            EsiContSetNewWay=89
        }

        [Serializable, SoapType(XmlNamespace = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses/ServerClasses%2C%20Version%3D1.0.0.0%2C%20Culture%3Dneutral%2C%20PublicKeyToken%3Dnull", XmlTypeNamespace = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses/ServerClasses%2C%20Version%3D1.0.0.0%2C%20Culture%3Dneutral%2C%20PublicKeyToken%3Dnull")]
        public enum _Rights : int
        {
            ClsAgreements_insert = 0,
            ClsAgreements_update = 1,
            ClsAgreements_delete = 2,
            ClsBlack_BL_insert = 3,
            ClsBlack_BLR_insert = 4,
            ClsBlack_BLR_update = 5,
            ClsBlack_BLR_delete = 6,
            ClsGroups_insert = 7,
            ClsGroups_update = 8,
            ClsGroups_delete = 9,
            ClsOffice_update = 10,
            ClsOffice_delete = 11,
            ClsOffice_insert = 12,
            ClsOffOper_Create = 13,
            ClsOffOper_Delete = 14,
            ClsOffOper_Update = 15,
            ClsOffOper_MyOffOperId = 16,
            ClsOperators_insert = 17,
            ClsOperators_delete = 18,
            ClsOperators_setTest = 19,
            ClsOperators_upDate = 20,
            ClsOperators_signInsert = 21,
            ClsOperators_signDelete = 22,
            ClsOperators_signUpdate = 23,
            confirm = 24,
            Request = 25,
            PrintWithPic = 26,
            PrintWithoutPic = 27,
            PrintAgainManager = 28,
            PassageTrainee = 29,
            PassageGuest = 30,
            PassageWorkerMan = 31,
            PassgeWorkerWoman = 32,
            ClsPersons_insert = 33,
            ClsPersons_delete = 34,
            ClsPersons_update = 35,
            ClsPersons_SetPictures = 36,
            ClsTravelAreas_insert = 37,
            ClsTravelAreas_update = 38,
            ClsVehicles_insert = 39,
            ClsVehicles_insert_Type = 40,
            ClsVehicles_update = 41,
            ClsVehicles_update_Type = 42,
            View_groups = 43,
            View_rights = 44,
            View_offices = 45,
            View_officeDetail = 46,
            View_operators = 47,
            View_operatorDetail = 48,
            View_agreements = 49,
            View_agreementDetail = 50,
            View_vehicles = 51,
            View_vehiclesType = 52,
            View_vehicleDetail = 53,
            View_travelAreas = 54,
            View_travelAreaDetail = 55,
            View_gatePasses = 56,
            View_gatePasseDetail = 57,
            View_packages = 58,
            View_packageDetail = 59,
            View_persons = 60,
            View_personDetail = 61,
            View_bLreasons = 62,
            View_bLreasonDetail = 63,
            View_blackLists = 64,
            View_blackListDetail = 65,
            SystemSettingsManager = 66,
            OperatorMobile = 67,
            ClsPacksGps_ExpireGp = 68,
            Report_person = 69,
            Report_office = 70,
            Report_vehicle = 71,
            Report_gatepass = 72,
            Report_blacklist = 73,
            Report_operator = 74,
            Report_Inout = 75,
            Report_personPrint = 76,
            Report_officePrint = 77,
            Report_vehiclePrint = 78,
            Report_gatepassPrint = 79,
            Report_blacklistPrint = 80,
            Report_operatorPrint = 81,
            Report_InoutPrint = 82,
            Report_Agreement = 83,
            Report_AgreementPrint = 84,
            ConfirmCar = 85,
            PassageNoTrainee = 86,
            PassageNoGuest = 87,
            PassageNoWorkerMan = 88,
            PassageNoWorkerWoman = 89,
            ReportLimitedPerson = 90,
            PassageArmy = 91,
            PassageTemp = 92,
            PassageNoArmy = 93,
            PassageNoTemp = 94,
            TagView = 95,
            TagConfirm = 96,
            TagUpdate = 97,
            TagRemove = 98 ,
            requestCard = 99 ,
            passageCard = 100 ,
            passageNoCard = 101 ,
            confirmCard = 102 ,
            PrintCard = 103 ,
            EsiGateViewGOff = 104 ,
            EsiGateMonitorGOff = 105,
            EsiGateSettingGOff = 106,
            EsiGateAallManager = 107
        }

    	[Serializable,
    	 SoapType(
    	 	XmlNamespace =
    	 		@"http://schemas.microsoft.com/clr/nsassem/ServerClasses/ServerClasses%2C%20Version%3D1.0.0.0%2C%20Culture%3Dneutral%2C%20PublicKeyToken%3Dnull"
    	 	,
    	 	XmlTypeNamespace =
    	 		@"http://schemas.microsoft.com/clr/nsassem/ServerClasses/ServerClasses%2C%20Version%3D1.0.0.0%2C%20Culture%3Dneutral%2C%20PublicKeyToken%3Dnull"
    	 	)]
    	public enum _TypePack : int
    	{
    		WorkerMan = 0,
    		WorkerWoman = 1,
    		TeachTrainee = 2,
    		TeachUni = 3,
    		TeachAct = 4,
    		Guest = 5,
    		TempWork = 6,
    		Company = 7,
            Army=8,
            Temp=9,
            CardPublic=10,
            CardCompany=11,
            CardArmy=12,
    	}

    	[Serializable, SoapType(XmlNamespace = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses/ServerClasses%2C%20Version%3D1.0.0.0%2C%20Culture%3Dneutral%2C%20PublicKeyToken%3Dnull", XmlTypeNamespace = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses/ServerClasses%2C%20Version%3D1.0.0.0%2C%20Culture%3Dneutral%2C%20PublicKeyToken%3Dnull")]
        public enum _StatePrint : int
        {
            Free = 0,
            Request = 1,
            Printing = 2,
            Complete = 3,
        }

        [Serializable, SoapType(XmlNamespace = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses/ServerClasses%2C%20Version%3D1.0.0.0%2C%20Culture%3Dneutral%2C%20PublicKeyToken%3Dnull", XmlTypeNamespace = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses/ServerClasses%2C%20Version%3D1.0.0.0%2C%20Culture%3Dneutral%2C%20PublicKeyToken%3Dnull")]
        public enum _GlobalSettings : int
        {
            MultiplePrint = 0,
            WihoutPicPrint = 1,
            TimeWaitRequestPrint = 2,
        }
    }

    [SoapType(XmlNamespace = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses/ServerClasses%2C%20Version%3D1.0.0.0%2C%20Culture%3Dneutral%2C%20PublicKeyToken%3Dnull", XmlTypeNamespace = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses/ServerClasses%2C%20Version%3D1.0.0.0%2C%20Culture%3Dneutral%2C%20PublicKeyToken%3Dnull")]
    [ComVisible(true)]
    public class OutputDatas : System.Runtime.Remoting.Services.RemotingClientProxy
    {
        // Constructor
        public OutputDatas()
        {
            base.ConfigureProxy(this.GetType(), aorc.gatepass.Properties.Settings.Default.ServerUri);
            System.Runtime.Remoting.SoapServices.PreLoad(typeof(ServerClasses.AllFunctions._IdData));
            System.Runtime.Remoting.SoapServices.PreLoad(typeof(ServerClasses.AllFunctions._IdMethod));
            System.Runtime.Remoting.SoapServices.PreLoad(typeof(ServerClasses.AllFunctions._Rights));
            System.Runtime.Remoting.SoapServices.PreLoad(typeof(ServerClasses.AllFunctions._TypePack));
            System.Runtime.Remoting.SoapServices.PreLoad(typeof(ServerClasses.AllFunctions._StatePrint));
            System.Runtime.Remoting.SoapServices.PreLoad(typeof(ServerClasses.AllFunctions._GlobalSettings));
        }

        public Object RemotingReference
        {
            get { return (_tp); }
        }

        public Boolean success
        {
            [SoapMethod(SoapAction = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses.OutputDatas/aorc.gatepass#get_success")]
            get { return ((OutputDatas)_tp).success; }

            [SoapMethod(SoapAction = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses.OutputDatas/aorc.gatepass#set_success")]
            set { ((OutputDatas)_tp).success = value; }
        }
        public String Message
        {
            [SoapMethod(SoapAction = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses.OutputDatas/aorc.gatepass#get_Message")]
            get { return ((OutputDatas)_tp).Message; }

            [SoapMethod(SoapAction = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses.OutputDatas/aorc.gatepass#set_Message")]
            set { ((OutputDatas)_tp).Message = value; }
        }

        public Boolean EsiBool
        {
            [SoapMethod(SoapAction = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses.OutputDatas/aorc.gatepass#get_EsiBool")]
            get { return ((OutputDatas)_tp).EsiBool; }

            [SoapMethod(SoapAction = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses.OutputDatas/aorc.gatepass#set_EsiBool")]
            set { ((OutputDatas)_tp).EsiBool = value; }
        }
        public String EsiMessage
        {
            [SoapMethod(SoapAction = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses.OutputDatas/aorc.gatepass#get_EsiMessage")]
            get { return ((OutputDatas)_tp).EsiMessage; }

            [SoapMethod(SoapAction = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses.OutputDatas/aorc.gatepass#set_EsiMessage")]
            set { ((OutputDatas)_tp).EsiMessage = value; }
        }
        
        public System.Data.DataTable ResultTable
        {
            [SoapMethod(SoapAction = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses.OutputDatas/aorc.gatepass#get_ResultTable")]
            get { return ((OutputDatas)_tp).ResultTable; }

            [SoapMethod(SoapAction = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses.OutputDatas/aorc.gatepass#set_ResultTable")]
            set { ((OutputDatas)_tp).ResultTable = value; }
        }

        public System.Data.DataTable MiniTable1
        {
            [SoapMethod(SoapAction = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses.OutputDatas/aorc.gatepass#get_MiniTable1")]
            get { return ((OutputDatas)_tp).MiniTable1; }

            [SoapMethod(SoapAction = @"http://schemas.microsoft.com/clr/nsassem/ServerClasses.OutputDatas/aorc.gatepass#set_MiniTable1")]
            set { ((OutputDatas)_tp).MiniTable1 = value; }
        }

    }
}
