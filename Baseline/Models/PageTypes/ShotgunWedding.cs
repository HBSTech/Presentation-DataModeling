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

[assembly: RegisterDocumentType(ShotgunWedding.CLASS_NAME, typeof(ShotgunWedding))]

namespace CMS.DocumentEngine.Types.NEWCC
{
    /// <summary>
    /// Represents a content item of type ShotgunWedding.
    /// </summary>
    public partial class ShotgunWedding : TreeNode
    {
        #region "Constants and variables"

        /// <summary>
        /// The name of the data class.
        /// </summary>
        public const string CLASS_NAME = "NEWCC.ShotgunWedding";


        /// <summary>
        /// The instance of the class that provides extended API for working with ShotgunWedding fields.
        /// </summary>
        private readonly ShotgunWeddingFields mFields;

        #endregion


        #region "Properties"

        /// <summary>
        /// ShotgunWeddingID.
        /// </summary>
        [DatabaseIDField]
        public int ShotgunWeddingID
        {
            get
            {
                return ValidationHelper.GetInteger(GetValue("ShotgunWeddingID"), 0);
            }
            set
            {
                SetValue("ShotgunWeddingID", value);
            }
        }


        /// <summary>
        /// Name.
        /// </summary>
        [DatabaseField]
        public string MenuName
        {
            get
            {
                return ValidationHelper.GetString(GetValue("MenuName"), @"");
            }
            set
            {
                SetValue("MenuName", value);
            }
        }


        /// <summary>
        /// Concert Name.
        /// </summary>
        [DatabaseField]
        public string ConcertName
        {
            get
            {
                return ValidationHelper.GetString(GetValue("ConcertName"), @"");
            }
            set
            {
                SetValue("ConcertName", value);
            }
        }


        /// <summary>
        /// Songs.
        /// </summary>
        [DatabaseField]
        public string Songs
        {
            get
            {
                return ValidationHelper.GetString(GetValue("Songs"), @"");
            }
            set
            {
                SetValue("Songs", value);
            }
        }


        /// <summary>
        /// Gets an object that provides extended API for working with ShotgunWedding fields.
        /// </summary>
        [RegisterProperty]
        public ShotgunWeddingFields Fields
        {
            get
            {
                return mFields;
            }
        }


        /// <summary>
        /// Provides extended API for working with ShotgunWedding fields.
        /// </summary>
        [RegisterAllProperties]
        public partial class ShotgunWeddingFields : AbstractHierarchicalObject<ShotgunWeddingFields>
        {
            /// <summary>
            /// The content item of type ShotgunWedding that is a target of the extended API.
            /// </summary>
            private readonly ShotgunWedding mInstance;


            /// <summary>
            /// Initializes a new instance of the <see cref="ShotgunWeddingFields" /> class with the specified content item of type ShotgunWedding.
            /// </summary>
            /// <param name="instance">The content item of type ShotgunWedding that is a target of the extended API.</param>
            public ShotgunWeddingFields(ShotgunWedding instance)
            {
                mInstance = instance;
            }


            /// <summary>
            /// ShotgunWeddingID.
            /// </summary>
            public int ID
            {
                get
                {
                    return mInstance.ShotgunWeddingID;
                }
                set
                {
                    mInstance.ShotgunWeddingID = value;
                }
            }


            /// <summary>
            /// Name.
            /// </summary>
            public string MenuName
            {
                get
                {
                    return mInstance.MenuName;
                }
                set
                {
                    mInstance.MenuName = value;
                }
            }


            /// <summary>
            /// Concert Name.
            /// </summary>
            public string ConcertName
            {
                get
                {
                    return mInstance.ConcertName;
                }
                set
                {
                    mInstance.ConcertName = value;
                }
            }


            /// <summary>
            /// Songs.
            /// </summary>
            public string Songs
            {
                get
                {
                    return mInstance.Songs;
                }
                set
                {
                    mInstance.Songs = value;
                }
            }
        }

        #endregion


        #region "Constructors"

        /// <summary>
        /// Initializes a new instance of the <see cref="ShotgunWedding" /> class.
        /// </summary>
        public ShotgunWedding() : base(CLASS_NAME)
        {
            mFields = new ShotgunWeddingFields(this);
        }

        #endregion
    }
}