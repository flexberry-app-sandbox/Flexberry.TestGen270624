﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLine.TestGen270624
{
    using ICSSoft.STORMNET;


    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Модель оборудования.
    /// </summary>
    // *** Start programmer edit section *** (МодельОборудования CustomAttributes)

    // *** End programmer edit section *** (МодельОборудования CustomAttributes)
    [PublishName("EquipmentModel")]
    [ClassStorage("EquipmentModel")]
    [AutoAltered()]
    [Caption("Модель оборудования")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("МодельОборудованияE", new string[] {
            "Наименование as \'Наименование\'",
            "Производитель as \'Производитель\'",
            "Производитель.Наименование as \'Наименование производителя\'"}, Hidden=new string[] {
            "Производитель.Наименование"})]
    [AssociatedDetailViewAttribute("МодельОборудованияE", "Документы", "ДокументКМоделиE", true, "", "Документы", true, new string[] {
            ""})]
    [MasterViewDefineAttribute("МодельОборудованияE", "Производитель", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Наименование")]
    [View("МодельОборудованияL", new string[] {
            "Наименование as \'Наименование\'",
            "Производитель.Наименование as \'Производитель\'"})]
    public class МодельОборудования : ICSSoft.STORMNET.DataObject
    {

        private string fНаименование;

        private DataLine.TestGen270624.Организация fПроизводитель;

        private DataLine.TestGen270624.DetailArrayOfДокументКМодели fДокументы;

        // *** Start programmer edit section *** (МодельОборудования CustomMembers)

        // *** End programmer edit section *** (МодельОборудования CustomMembers)


        /// <summary>
        /// Наименование.
        /// </summary>
        // *** Start programmer edit section *** (МодельОборудования.Наименование CustomAttributes)

        // *** End programmer edit section *** (МодельОборудования.Наименование CustomAttributes)
        [PropertyStorage("Name")]
        [PublishName("Name")]
        [NotNull()]
        public virtual string Наименование
        {
            get
            {
                // *** Start programmer edit section *** (МодельОборудования.Наименование Get start)

                // *** End programmer edit section *** (МодельОборудования.Наименование Get start)
                string result = this.fНаименование;
                // *** Start programmer edit section *** (МодельОборудования.Наименование Get end)

                // *** End programmer edit section *** (МодельОборудования.Наименование Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (МодельОборудования.Наименование Set start)

                // *** End programmer edit section *** (МодельОборудования.Наименование Set start)
                this.fНаименование = value;
                // *** Start programmer edit section *** (МодельОборудования.Наименование Set end)

                // *** End programmer edit section *** (МодельОборудования.Наименование Set end)
            }
        }

        /// <summary>
        /// Модель оборудования.
        /// </summary>
        // *** Start programmer edit section *** (МодельОборудования.Производитель CustomAttributes)

        // *** End programmer edit section *** (МодельОборудования.Производитель CustomAttributes)
        [PropertyStorage(new string[] {
                "Manufacturer"})]
        [PublishName("Manufacturer")]
        public virtual DataLine.TestGen270624.Организация Производитель
        {
            get
            {
                // *** Start programmer edit section *** (МодельОборудования.Производитель Get start)

                // *** End programmer edit section *** (МодельОборудования.Производитель Get start)
                DataLine.TestGen270624.Организация result = this.fПроизводитель;
                // *** Start programmer edit section *** (МодельОборудования.Производитель Get end)

                // *** End programmer edit section *** (МодельОборудования.Производитель Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (МодельОборудования.Производитель Set start)

                // *** End programmer edit section *** (МодельОборудования.Производитель Set start)
                this.fПроизводитель = value;
                // *** Start programmer edit section *** (МодельОборудования.Производитель Set end)

                // *** End programmer edit section *** (МодельОборудования.Производитель Set end)
            }
        }

        /// <summary>
        /// Модель оборудования.
        /// </summary>
        // *** Start programmer edit section *** (МодельОборудования.Документы CustomAttributes)

        // *** End programmer edit section *** (МодельОборудования.Документы CustomAttributes)
        [PublishName("Documents")]
        public virtual DataLine.TestGen270624.DetailArrayOfДокументКМодели Документы
        {
            get
            {
                // *** Start programmer edit section *** (МодельОборудования.Документы Get start)

                // *** End programmer edit section *** (МодельОборудования.Документы Get start)
                if ((this.fДокументы == null))
                {
                    this.fДокументы = new DataLine.TestGen270624.DetailArrayOfДокументКМодели(this);
                }
                DataLine.TestGen270624.DetailArrayOfДокументКМодели result = this.fДокументы;
                // *** Start programmer edit section *** (МодельОборудования.Документы Get end)

                // *** End programmer edit section *** (МодельОборудования.Документы Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (МодельОборудования.Документы Set start)

                // *** End programmer edit section *** (МодельОборудования.Документы Set start)
                this.fДокументы = value;
                // *** Start programmer edit section *** (МодельОборудования.Документы Set end)

                // *** End programmer edit section *** (МодельОборудования.Документы Set end)
            }
        }

        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {

            /// <summary>
            /// "МодельОборудованияE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View МодельОборудованияE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("МодельОборудованияE", typeof(DataLine.TestGen270624.МодельОборудования));
                }
            }

            /// <summary>
            /// "МодельОборудованияL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View МодельОборудованияL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("МодельОборудованияL", typeof(DataLine.TestGen270624.МодельОборудования));
                }
            }
        }
    }
}

