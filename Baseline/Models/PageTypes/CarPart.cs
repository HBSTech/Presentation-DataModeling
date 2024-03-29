﻿//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine.Types.NEWCC;
using CMS.DocumentEngine;

[assembly: RegisterDocumentType(CarPart.CLASS_NAME, typeof(CarPart))]

namespace CMS.DocumentEngine.Types.NEWCC
{
    /// <summary>
    /// Represents a content item of type CarPart.
    /// </summary>
    public partial class CarPart : TreeNode
    {
        #region "Constants and variables"

        /// <summary>
        /// The name of the data class.
        /// </summary>
        public const string CLASS_NAME = "NEWCC.CarPart";


        /// <summary>
        /// The instance of the class that provides extended API for working with CarPart fields.
        /// </summary>
        private readonly CarPartFields mFields;

        #endregion


        #region "Properties"

        /// <summary>
        /// CarPartID.
        /// </summary>
        [DatabaseIDField]
        public int CarPartID
        {
            get
            {
                return ValidationHelper.GetInteger(GetValue("CarPartID"), 0);
            }
            set
            {
                SetValue("CarPartID", value);
            }
        }


        /// <summary>
        /// Name.
        /// </summary>
        [DatabaseField]
        public string CarPartName
        {
            get
            {
                return ValidationHelper.GetString(GetValue("CarPartName"), @"");
            }
            set
            {
                SetValue("CarPartName", value);
            }
        }


        /// <summary>
        /// Image Url.
        /// </summary>
        [DatabaseField]
        public string ImageUrl
        {
            get
            {
                return ValidationHelper.GetString(GetValue("ImageUrl"), @"");
            }
            set
            {
                SetValue("ImageUrl", value);
            }
        }


        /// <summary>
        /// Description.
        /// </summary>
        [DatabaseField]
        public string Description
        {
            get
            {
                return ValidationHelper.GetString(GetValue("Description"), @"");
            }
            set
            {
                SetValue("Description", value);
            }
        }


        /// <summary>
        /// Gets an object that provides extended API for working with CarPart fields.
        /// </summary>
        [RegisterProperty]
        public CarPartFields Fields
        {
            get
            {
                return mFields;
            }
        }


        /// <summary>
        /// Provides extended API for working with CarPart fields.
        /// </summary>
        [RegisterAllProperties]
        public partial class CarPartFields : AbstractHierarchicalObject<CarPartFields>
        {
            /// <summary>
            /// The content item of type CarPart that is a target of the extended API.
            /// </summary>
            private readonly CarPart mInstance;


            /// <summary>
            /// Initializes a new instance of the <see cref="CarPartFields" /> class with the specified content item of type CarPart.
            /// </summary>
            /// <param name="instance">The content item of type CarPart that is a target of the extended API.</param>
            public CarPartFields(CarPart instance)
            {
                mInstance = instance;
            }


            /// <summary>
            /// CarPartID.
            /// </summary>
            public int ID
            {
                get
                {
                    return mInstance.CarPartID;
                }
                set
                {
                    mInstance.CarPartID = value;
                }
            }


            /// <summary>
            /// Name.
            /// </summary>
            public string Name
            {
                get
                {
                    return mInstance.CarPartName;
                }
                set
                {
                    mInstance.CarPartName = value;
                }
            }


            /// <summary>
            /// Image Url.
            /// </summary>
            public string ImageUrl
            {
                get
                {
                    return mInstance.ImageUrl;
                }
                set
                {
                    mInstance.ImageUrl = value;
                }
            }


            /// <summary>
            /// Description.
            /// </summary>
            public string Description
            {
                get
                {
                    return mInstance.Description;
                }
                set
                {
                    mInstance.Description = value;
                }
            }
        }

        #endregion


        #region "Constructors"

        /// <summary>
        /// Initializes a new instance of the <see cref="CarPart" /> class.
        /// </summary>
        public CarPart() : base(CLASS_NAME)
        {
            mFields = new CarPartFields(this);
        }

        #endregion
    }
}