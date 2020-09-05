using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServerClasses;

namespace aorc.gatepass
{
     class PoliceClient : AllFunctions
    {
        private const char _delimiter = '|';
        private void Exceptor(Exception  Ex,params string[] FarsiMessage)
        {
            string str="";
            foreach (string subStr in FarsiMessage)
            {
                str += subStr+"\n";
            }
            str += _delimiter + "\nType:\n" + Ex.GetType() + "\nMessage:\n" + Ex.Message + "\nSource:\n" + Ex.Source;
            throw new Exception(str);
        }
        private static void Exceptor( params string[] FarsiMessage)
        {
            var str = FarsiMessage.Aggregate("", (current, subStr) => current + (subStr + "\n"));
            // str += _delimiter;
            throw new Exception(str);
        }
        private void  policeAndRights(ref Dictionary<_IdData, object> datas, params _Rights[] methodRights)
        {
            var userRights = ItemsPublic.MyRights;
            foreach (_Rights item in methodRights.Where(item => !userRights.Contains(item)))
            {
                Exceptor("خطای عدم دسترسی");
                //datas[_IdData.Event_Description] += "\n" + "خطای عدم دسترسی";
                //throw new Exception();
            }
        }
        private bool  policeOrRights(ref Dictionary<_IdData, object> datas, params _Rights[] methodRights)
        {
            var userRights = ItemsPublic.MyRights;
            if (methodRights.Any(userRights.Contains))
            {
                return true;
            }
            Exceptor("خطای عدم دسترسی");
            return false;
            //datas[_IdData.Event_Description] += "\n" + "خطای عدم دسترسی";
            //throw new Exception();
        }
        public bool isPersonSetWithTypePack(bool isWoman, _TypePack typePack)
        {
            switch (typePack)
            {
                case _TypePack.WorkerMan:
                    if (isWoman)
                    {
                        return false;
                    }
                    break;
                case _TypePack.WorkerWoman:
                    if (! isWoman)
                    {
                        return false;
                    }
                    break;
            }
            return true;
            //@
        }
        public bool packTimeIsTrue(DateTime firstTime, DateTime endTime)
        {
            if (firstTime.Date > endTime.Date)
            {
                return false;
            }
            return true;
            //@
        }
        public bool packAndGates(DateTime firstTime , DateTime endTime,int areaId, decimal  idPerson)
        {
 
            return true;
            //@
        }
        public bool TypeAndAgreeIsTrue(_TypePack tp, ref Dictionary<_IdData, object> datas)
        {
			if ( datas.ContainsKey ( _IdData.Agreement_ID ) )
			{
				switch ( tp )
				{
					case _TypePack.WorkerMan:
						return true;
					case _TypePack.WorkerWoman:
						return true;
				}
			}
			else
			{
				switch ( tp )
				{
					case _TypePack.TeachTrainee:
						return true;
					case _TypePack.TeachUni:
						return true;
					case _TypePack.TeachAct:
						return true;
					case _TypePack.Guest:
						return true;
					case _TypePack.TempWork:
						return true;
					case _TypePack.Company:
						return true;
				}
			}
			return false;
            //@
        }
        public void checkStates(ref Dictionary<_IdData, object> datas
            , DateTime Ftime, DateTime Etime, _TypePack typePack, int TravelId)
        {
            bool ERR = false;
         //   IEnumerable<decimal> IdPersons = (IEnumerable<decimal>)datas[_IdData.Package_CollectionGps];

            if (!packTimeIsTrue(Ftime, Etime))
            {
                ERR = true;
               // datas[_IdData.Event_Description] += "\n" + "تاریخ شروع یا پایان نادرست است";
				Exceptor("تاریخ شروع یا پایان نادرست است");
            }
            if (!TypeAndAgreeIsTrue(typePack, ref datas))
            {
                ERR = true;
              //  datas[_IdData.Event_Description] += "\n" + "تنظیمات نوع و قرارداد متناسب نیستند";
				Exceptor("تنظیمات نوع و قرارداد متناسب نیستند");
            }
        //    foreach (decimal item in IdPersons)
        //    {
/*

                Person objP = GP.Persons.Single(x => x.Person_ID == item);

                if (!isPersonSetWithTypePack(objP.Person_isWoman, typePack))
                {
                    ERR = true;
                    datas[_IdData.Event_Description] += "\n" + "نوع بسته با شخص انتخابی به مشخصات زیر همخوانی ندارد ";
                    datas[_IdData.Event_Description] += "\n"+"کد ملی: "+  objP.Person_NationalCode;
                    datas[_IdData.Event_Description] += "\n"+"شماره شناسایی: " + objP.Person_IdentifyCode;
                    }
                if (isPersonBlackLists(item))
                {
                    ERR = true;
                    datas[_IdData.Event_Description] += "\n" + "شخصی به مشخصات زیر در لیست سیاه قرار دارد";
                    datas[_IdData.Event_Description] += "\n"+"کد ملی: "+  objP.Person_NationalCode;
                    datas[_IdData.Event_Description] += "\n"+"شماره شناسایی: " + objP.Person_IdentifyCode;
                }
                if (packAndGates(Ftime, Etime, TravelId, item))
                {
                    ERR = true;
                    datas[_IdData.Event_Description] += "\n" + "تنظیمات مجوز تردد ها یا بسته اشتباه می باشد";
                }
                */
        //    }
            if (ERR)
            {
                Exceptor((string)datas[_IdData.Event_Description]);
            }
        }

        private void IsActice(ref Dictionary<_IdData, object> datas)
        {
               
        }
        # region List Polices
        public void ClsAgreements_insert(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsAgreements_insert );
            var dts1 = (DateTime) datas[_IdData.Agreement_StartDate];
            var dte1 = (DateTime) datas[_IdData.Agreement_EndDate];
                     if (dts1.Date > dte1.Date)
                     {
                         Exceptor("تاریخ پایان نمی تواند قبل از تاریخ شروع قرارداد باشد");
                     }
       //!?$
        }
        public void ClsAgreements_update(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsAgreements_update );
            var dts1 = (DateTime)datas[_IdData.Agreement_StartDate];
            var dte1 = (DateTime)datas[_IdData.Agreement_EndDate];
            if (dts1.Date > dte1.Date)
            {
                Exceptor("تاریخ پایان نمی تواند قبل از تاریخ شروع قرارداد باشد");
              //  datas[_IdData.Event_Description] += "\n" + "تنظیمات زمان اشتباه است";
               // throw new Exception();
            }
            // policeAndRights(ref datas, _Rights.);
            //!?$
        }
        public void ClsAgreements_delete(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsAgreements_delete );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsBlack_BL_insert(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsBlack_BL_insert );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsBlack_BLR_insert(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsBlack_BLR_insert );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsBlack_BLR_update(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsBlack_BLR_update );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsBlack_BLR_delete(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsBlack_BLR_delete );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsGroups_insert(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsGroups_insert );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsGroups_update(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsGroups_update );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsGroups_delete(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsGroups_delete );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsOffice_update(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsOffice_update );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsOffice_delete(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsOffice_delete );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsOffice_insert(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsOffice_insert );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsOffOper_Create(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsOffOper_Create );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsOffOper_Delete(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsOffOper_Delete );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsOffOper_Update(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsOffOper_Update );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsOffOper_MyOffOperId(ref Dictionary<_IdData, object> datas)
        {
            //policeAndRights(ref datas, _Rights.ClsOffOper_MyOffOperId );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsOperators_insert(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsOperators_insert );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsOperators_delete(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsOperators_delete );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsOperators_setTest(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsOperators_setTest );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsOperators_upDate(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsOperators_upDate );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsOperators_signInsert(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsOperators_signInsert );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsOperators_signDelete(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsOperators_signDelete );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsOperators_signUpdate(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsOperators_signUpdate );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }

        public void ClsPacksGps_insertPackGps(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.Request);
            //checkStates(ref datas, (DateTime)datas[_IdData.Package_StartDate]
            //                     , (DateTime)datas[_IdData.Package_EndDate]
            //                     , (_TypePack)datas[_IdData.TypePack_Id]
            //                     , (int)datas[_IdData.TravelArea_Id]);

            //!?$
        }
        public void ClsPacksGps_updatePackGps(ref Dictionary<_IdData, object> datas)
        {

            
            //!?$
        }
        public void ClsPacksGps_confirm(ref Dictionary<_IdData, object> datas)
        {
           

            //!?$
        }
        public void ClsPacksGps_passage(ref Dictionary<_IdData, object> datas)
        {
         

            //!?$
        }

        public void ClsPacksGps_RequestPrintGP(ref Dictionary<_IdData, object> datas)
        {
			policeOrRights ( ref datas , _Rights.PrintWithoutPic , _Rights.PrintWithPic );
            //!?$
        }
        public void ClsPacksGps_PrintingGp(ref Dictionary<_IdData, object> datas)
        {

			policeOrRights ( ref datas , _Rights.PrintWithoutPic , _Rights.PrintWithPic );


            //!?$
        }
        public void ClsPacksGps_PrintedGP(ref Dictionary<_IdData, object> datas)
        {
			policeOrRights ( ref datas , _Rights.PrintWithoutPic , _Rights.PrintWithPic );
        }
        public void ClsPacksGps_FreePrintGP(ref Dictionary<_IdData, object> datas)
        {

            policeAndRights(ref datas, _Rights.PrintAgainManager);

            //// policeAndRights(ref datas, _Rights.);

           



            //!?$
        }
       
        public void ClsPersons_insert(ref Dictionary<_IdData, object> datas)
        {

			var userRights = ItemsPublic.MyRights;
			policeOrRights ( ref datas , _Rights.ClsPersons_insert , _Rights.Request );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsPersons_delete(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsPersons_delete );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsPersons_update(ref Dictionary<_IdData, object> datas)
        {
            policeOrRights(ref datas, _Rights.ClsPersons_update,_Rights.Request );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsTravelAreas_insert(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsTravelAreas_insert );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsTravelAreas_update(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsTravelAreas_update );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsVehicles_insert(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsVehicles_insert );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsVehicles_insert_Type(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsVehicles_insert_Type );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsVehicles_update(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsVehicles_update );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void ClsVehicles_update_Type(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.ClsVehicles_update_Type );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void View_groups(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.View_groups );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void View_rights(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.View_rights );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void View_offices(ref Dictionary<_IdData, object> datas)
        {
         //   policeAndRights(ref datas, _Rights.View_offices );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void View_officeDetail(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.View_officeDetail );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void View_operators(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.View_operators );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void View_operatorDetail(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.View_operatorDetail );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void View_agreements(ref Dictionary<_IdData, object> datas)
        {
            policeOrRights(ref datas, _Rights.View_agreements,_Rights.Request );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void View_agreementDetail(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.View_agreementDetail );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void View_vehicles(ref Dictionary<_IdData, object> datas)
        {
			policeOrRights ( ref datas , _Rights.View_vehicles , _Rights.Request );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void View_vehiclesType(ref Dictionary<_IdData, object> datas)
        {
			policeOrRights ( ref datas , _Rights.View_vehiclesType , _Rights.Request , _Rights.confirm , _Rights.PassageGuest , _Rights.PassageTrainee , _Rights.PassageWorkerMan , _Rights.PassgeWorkerWoman , _Rights.View_packages );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void View_vehicleDetail(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.View_vehicleDetail );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void View_travelAreas(ref Dictionary<_IdData, object> datas)
        {
			policeOrRights ( ref datas , _Rights.View_travelAreas , _Rights.Request );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void View_travelAreaDetail(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.View_travelAreaDetail );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void View_gatePasses(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.View_gatePasses );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void View_gatePasseDetail(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.View_gatePasseDetail );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void View_packages(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.View_packages );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void View_packageDetail(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.View_packageDetail );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void View_persons(ref Dictionary<_IdData, object> datas)
        {
			//policeOrRights ( ref datas , _Rights.View_persons , _Rights.Request );

            // policeAndRights(ref datas, _Rights.);
            var userRights = ItemsPublic.MyRights;
            if (userRights.Contains(_Rights.View_persons))
            {
                return ;
            }
            
            if(userRights.Contains(_Rights.Request) && datas.ContainsKey(_IdData.Person_NationalCode))
            {
                var val = (string)datas[_IdData.Person_NationalCode];
                if (val.Count()!=10)
                {
                    Exceptor("ابتدا کد ملی را کامل وارد نمایید");
                }
                datas.Add(_IdData.Person_SmartFind, val);
                datas.Remove(_IdData.Person_NationalCode);
                return ;
            }

            if (userRights.Contains(_Rights.Request))
            {
                return;
            }


            Exceptor("خطای عدم دسترسی");



            //!?$
        }
        public void View_personDetail(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.View_personDetail );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void View_bLreasons(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.View_bLreasons );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void View_bLreasonDetail(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.View_bLreasonDetail );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void View_blackLists(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.View_blackLists );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }
        public void View_blackListDetail(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.View_blackListDetail );

            // policeAndRights(ref datas, _Rights.);

            //!?$
        }

        #endregion
           
     	public void ClsGlobalSetting_View(ref Dictionary<_IdData, object> datas)
     	{
			policeAndRights ( ref datas , _Rights.SystemSettingsManager );
     	}

		public void ClsGlobalSetting_update( ref Dictionary<_IdData , object> datas )
     	{
			policeAndRights ( ref datas , _Rights.SystemSettingsManager );
     	}

		public void ClsPacksGps_ExpireGp( ref Dictionary<_IdData , object> datas )
     	{
			policeAndRights ( ref datas , _Rights.ClsPacksGps_ExpireGp );
     	}

		public void ClsLocations_Nationality_insert( ref Dictionary<_IdData , object> datas )
     	{
			policeOrRights ( ref datas , _Rights.ClsPersons_insert,_Rights.Request );
     	}

		public void ClsLocations_City_insert( ref Dictionary<_IdData , object> datas )
     	{
			policeOrRights ( ref datas , _Rights.ClsPersons_insert , _Rights.Request );
     	}

        public void ReportInOut(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.Report_Inout);
        }

        public void UpdateTag(ref Dictionary<_IdData, object> datas)
        {
            policeAndRights(ref datas, _Rights.TagView,_Rights.TagUpdate);
        }

        internal void ClsPacksGps_RegisterCards(ref Dictionary<_IdData, object> datas)
        {
            policeOrRights(ref datas, _Rights.PrintCard);
        }
    }
   
}

