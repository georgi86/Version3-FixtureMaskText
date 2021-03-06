﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace FixtureMaskText
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the FixtureMaskTextRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
    [RepositoryFolder("0e37c180-8858-4e48-b840-d2010a5236b0")]
    public partial class FixtureMaskTextRepository : RepoGenBaseFolder
    {
        static FixtureMaskTextRepository instance = new FixtureMaskTextRepository();
        FixtureMaskTextRepositoryFolders.SnapXUntitledAppFolder _snapxuntitled;
        FixtureMaskTextRepositoryFolders.SNAPXAppFolder _snapx;
        FixtureMaskTextRepositoryFolders.DropDownButtonAppFolder _dropdownbutton;

        /// <summary>
        /// Gets the singleton class instance representing the FixtureMaskTextRepository element repository.
        /// </summary>
        [RepositoryFolder("0e37c180-8858-4e48-b840-d2010a5236b0")]
        public static FixtureMaskTextRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public FixtureMaskTextRepository() 
            : base("FixtureMaskTextRepository", "/", null, 0, false, "0e37c180-8858-4e48-b840-d2010a5236b0", ".\\RepositoryImages\\FixtureMaskTextRepository0e37c180.rximgres")
        {
            _snapxuntitled = new FixtureMaskTextRepositoryFolders.SnapXUntitledAppFolder(this);
            _snapx = new FixtureMaskTextRepositoryFolders.SNAPXAppFolder(this);
            _dropdownbutton = new FixtureMaskTextRepositoryFolders.DropDownButtonAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("0e37c180-8858-4e48-b840-d2010a5236b0")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The SnapXUntitled folder.
        /// </summary>
        [RepositoryFolder("6e196128-cab2-41f0-89f0-ff55534d84fe")]
        public virtual FixtureMaskTextRepositoryFolders.SnapXUntitledAppFolder SnapXUntitled
        {
            get { return _snapxuntitled; }
        }

        /// <summary>
        /// The SNAPX folder.
        /// </summary>
        [RepositoryFolder("8175cfff-36e3-420f-b6ff-fe819f55a322")]
        public virtual FixtureMaskTextRepositoryFolders.SNAPXAppFolder SNAPX
        {
            get { return _snapx; }
        }

        /// <summary>
        /// The DropDownButton folder.
        /// </summary>
        [RepositoryFolder("cb31ea8e-07df-4655-9007-937762a1805c")]
        public virtual FixtureMaskTextRepositoryFolders.DropDownButtonAppFolder DropDownButton
        {
            get { return _dropdownbutton; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
    public partial class FixtureMaskTextRepositoryFolders
    {
        /// <summary>
        /// The SnapXUntitledAppFolder folder.
        /// </summary>
        [RepositoryFolder("6e196128-cab2-41f0-89f0-ff55534d84fe")]
        public partial class SnapXUntitledAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _textmeasureInfo;
            RepoItemInfo _switchtosensorInfo;
            RepoItemInfo _fixturesubstractionbuttonInfo;
            RepoItemInfo _createfixturemaskInfo;

            /// <summary>
            /// Creates a new SnapXUntitled  folder.
            /// </summary>
            public SnapXUntitledAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SNAPXUntitled", "/form[@title='SNAP-X - [Untitled]']", parentFolder, 30000, null, true, "6e196128-cab2-41f0-89f0-ff55534d84fe", "")
            {
                _textmeasureInfo = new RepoItemInfo(this, "TextMeasure", "container[@controlid='59648']/form[@title='Untitled']//text[@controlid='2394']", 30000, null, "f80af225-e014-4e38-9b45-38cb18157157");
                _switchtosensorInfo = new RepoItemInfo(this, "SwitchToSensor", "container[@controlid='59648']/form[@title='Untitled']/?/?/element[@controlid='59650']/element[@controlid='59648']/toolbar[@controlid='59392']/button[@commandid='40029']", 30000, null, "98b23837-9e3f-41bd-842f-5e68cd62b4d5");
                _fixturesubstractionbuttonInfo = new RepoItemInfo(this, "FixtureSubstractionButton", "?/?/form[@title='Untitled']//toolbar[@controlid='59392']/button[@commandid='40161']", 30000, null, "d2307a3a-c590-41c3-9f5a-a115ead5e9ac");
                _createfixturemaskInfo = new RepoItemInfo(this, "CreateFixtureMask", "?/?/form[@title='Untitled']//toolbar[@controlid='59392']/button[@commandid='40162']", 30000, null, "c41e128b-c951-4bbf-93ee-8f68c2c878ae");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("6e196128-cab2-41f0-89f0-ff55534d84fe")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("6e196128-cab2-41f0-89f0-ff55534d84fe")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TextMeasure item.
            /// </summary>
            [RepositoryItem("f80af225-e014-4e38-9b45-38cb18157157")]
            public virtual Ranorex.Text TextMeasure
            {
                get
                {
                    return _textmeasureInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The TextMeasure item info.
            /// </summary>
            [RepositoryItemInfo("f80af225-e014-4e38-9b45-38cb18157157")]
            public virtual RepoItemInfo TextMeasureInfo
            {
                get
                {
                    return _textmeasureInfo;
                }
            }

            /// <summary>
            /// The SwitchToSensor item.
            /// </summary>
            [RepositoryItem("98b23837-9e3f-41bd-842f-5e68cd62b4d5")]
            public virtual Ranorex.Button SwitchToSensor
            {
                get
                {
                    return _switchtosensorInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The SwitchToSensor item info.
            /// </summary>
            [RepositoryItemInfo("98b23837-9e3f-41bd-842f-5e68cd62b4d5")]
            public virtual RepoItemInfo SwitchToSensorInfo
            {
                get
                {
                    return _switchtosensorInfo;
                }
            }

            /// <summary>
            /// The FixtureSubstractionButton item.
            /// </summary>
            [RepositoryItem("d2307a3a-c590-41c3-9f5a-a115ead5e9ac")]
            public virtual Ranorex.Button FixtureSubstractionButton
            {
                get
                {
                    return _fixturesubstractionbuttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The FixtureSubstractionButton item info.
            /// </summary>
            [RepositoryItemInfo("d2307a3a-c590-41c3-9f5a-a115ead5e9ac")]
            public virtual RepoItemInfo FixtureSubstractionButtonInfo
            {
                get
                {
                    return _fixturesubstractionbuttonInfo;
                }
            }

            /// <summary>
            /// The CreateFixtureMask item.
            /// </summary>
            [RepositoryItem("c41e128b-c951-4bbf-93ee-8f68c2c878ae")]
            public virtual Ranorex.Button CreateFixtureMask
            {
                get
                {
                    return _createfixturemaskInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The CreateFixtureMask item info.
            /// </summary>
            [RepositoryItemInfo("c41e128b-c951-4bbf-93ee-8f68c2c878ae")]
            public virtual RepoItemInfo CreateFixtureMaskInfo
            {
                get
                {
                    return _createfixturemaskInfo;
                }
            }
        }

        /// <summary>
        /// The SNAPXAppFolder folder.
        /// </summary>
        [RepositoryFolder("8175cfff-36e3-420f-b6ff-fe819f55a322")]
        public partial class SNAPXAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _inspectedtitleInfo;
            RepoItemInfo _inspectedtextInfo;

            /// <summary>
            /// Creates a new SNAPX  folder.
            /// </summary>
            public SNAPXAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SNAPX", "/form[@title='SNAP-X']", parentFolder, 30000, null, true, "8175cfff-36e3-420f-b6ff-fe819f55a322", "")
            {
                _inspectedtitleInfo = new RepoItemInfo(this, "InspectedTitle", "titlebar[@accessiblerole='TitleBar']", 30000, null, "63e63377-2c5d-454f-a77b-3b7002a01ab5");
                _inspectedtextInfo = new RepoItemInfo(this, "InspectedText", "text[@controlid='65535']", 30000, null, "630357c8-abb8-43e6-9d14-7d5296da494f");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("8175cfff-36e3-420f-b6ff-fe819f55a322")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("8175cfff-36e3-420f-b6ff-fe819f55a322")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The InspectedTitle item.
            /// </summary>
            [RepositoryItem("63e63377-2c5d-454f-a77b-3b7002a01ab5")]
            public virtual Ranorex.TitleBar InspectedTitle
            {
                get
                {
                    return _inspectedtitleInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The InspectedTitle item info.
            /// </summary>
            [RepositoryItemInfo("63e63377-2c5d-454f-a77b-3b7002a01ab5")]
            public virtual RepoItemInfo InspectedTitleInfo
            {
                get
                {
                    return _inspectedtitleInfo;
                }
            }

            /// <summary>
            /// The InspectedText item.
            /// </summary>
            [RepositoryItem("630357c8-abb8-43e6-9d14-7d5296da494f")]
            public virtual Ranorex.Text InspectedText
            {
                get
                {
                    return _inspectedtextInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The InspectedText item info.
            /// </summary>
            [RepositoryItemInfo("630357c8-abb8-43e6-9d14-7d5296da494f")]
            public virtual RepoItemInfo InspectedTextInfo
            {
                get
                {
                    return _inspectedtextInfo;
                }
            }
        }

        /// <summary>
        /// The DropDownButtonAppFolder folder.
        /// </summary>
        [RepositoryFolder("cb31ea8e-07df-4655-9007-937762a1805c")]
        public partial class DropDownButtonAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _createfixturemaskInfo;
            RepoItemInfo _fixturewithmaskInfo;

            /// <summary>
            /// Creates a new DropDownButton  folder.
            /// </summary>
            public DropDownButtonAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DropDownButton", "/contextmenu[@processname='SNAP-X']", parentFolder, 30000, null, false, "cb31ea8e-07df-4655-9007-937762a1805c", "")
            {
                _createfixturemaskInfo = new RepoItemInfo(this, "CreateFixtureMask", "?/?/menuitem[@accessiblename='Create Fixture Mask...']", 30000, null, "a34d2729-0831-4bf9-8c33-f025b44cfb17");
                _fixturewithmaskInfo = new RepoItemInfo(this, "FixtureWithMask", "?/?/menuitem[@accessiblename='Fixture with Mask']", 30000, null, "30ef917f-1efc-4003-9b4e-8daacf99e93e");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("cb31ea8e-07df-4655-9007-937762a1805c")]
            public virtual Ranorex.ContextMenu Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.ContextMenu>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("cb31ea8e-07df-4655-9007-937762a1805c")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The CreateFixtureMask item.
            /// </summary>
            [RepositoryItem("a34d2729-0831-4bf9-8c33-f025b44cfb17")]
            public virtual Ranorex.MenuItem CreateFixtureMask
            {
                get
                {
                    return _createfixturemaskInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The CreateFixtureMask item info.
            /// </summary>
            [RepositoryItemInfo("a34d2729-0831-4bf9-8c33-f025b44cfb17")]
            public virtual RepoItemInfo CreateFixtureMaskInfo
            {
                get
                {
                    return _createfixturemaskInfo;
                }
            }

            /// <summary>
            /// The FixtureWithMask item.
            /// </summary>
            [RepositoryItem("30ef917f-1efc-4003-9b4e-8daacf99e93e")]
            public virtual Ranorex.MenuItem FixtureWithMask
            {
                get
                {
                    return _fixturewithmaskInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The FixtureWithMask item info.
            /// </summary>
            [RepositoryItemInfo("30ef917f-1efc-4003-9b4e-8daacf99e93e")]
            public virtual RepoItemInfo FixtureWithMaskInfo
            {
                get
                {
                    return _fixturewithmaskInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}