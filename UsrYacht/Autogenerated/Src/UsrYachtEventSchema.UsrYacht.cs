namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrYachtEventSchema

	/// <exclude/>
	public class UsrYachtEventSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrYachtEventSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrYachtEventSchema(UsrYachtEventSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3aae87d0-c8a8-4cc9-a788-1228f8d4036d");
			Name = "UsrYachtEvent";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9a31d3b2-db46-42fd-a3f5-4b997d8744c7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,81,107,219,48,16,199,223,11,253,14,135,159,108,8,162,123,93,183,194,18,210,81,40,219,104,156,65,25,123,80,228,139,163,33,75,70,39,167,203,70,191,251,78,82,210,166,78,7,189,23,71,167,191,126,119,255,203,129,149,29,82,47,21,66,141,222,75,114,235,32,102,206,174,117,59,120,25,180,179,231,103,127,207,207,128,99,32,109,91,88,236,40,96,119,121,156,58,126,216,117,206,254,247,210,163,152,219,160,131,70,122,139,70,204,183,104,195,65,250,35,165,119,41,119,171,185,9,139,190,92,168,13,118,242,11,123,128,143,80,44,201,223,75,181,9,69,245,51,191,233,135,149,209,10,148,145,68,144,174,94,129,192,123,152,74,194,87,110,50,100,111,255,136,231,182,220,176,110,16,182,78,55,240,213,46,228,150,109,148,110,245,11,85,0,66,219,160,159,64,6,78,113,205,158,18,246,147,111,9,176,122,198,29,145,99,172,184,11,241,68,59,96,176,186,124,41,203,92,216,69,59,236,186,204,231,42,235,71,218,6,149,238,164,129,222,107,21,71,148,30,137,207,24,234,93,143,205,204,153,161,179,223,165,25,240,195,94,121,85,198,41,126,139,242,98,92,88,175,161,204,160,43,120,119,17,163,122,41,24,249,137,129,226,134,102,210,42,52,216,112,253,224,7,100,234,169,142,130,143,155,192,187,72,178,197,26,187,222,200,16,59,182,248,0,183,78,73,163,255,200,149,193,69,210,149,217,199,146,208,243,174,90,158,58,47,170,184,67,114,131,87,172,113,158,33,147,211,42,49,158,182,36,253,39,197,4,138,19,60,137,52,147,27,170,157,155,234,54,159,138,74,212,110,95,190,122,131,7,238,61,39,196,181,243,157,12,229,200,27,23,230,33,2,79,17,230,203,187,147,97,199,8,27,239,30,210,4,230,191,21,246,209,228,129,50,150,63,62,31,247,63,249,243,248,15,177,6,14,52,222,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c936836f-08e6-64bb-ca8c-ec3d35bec136"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("9a31d3b2-db46-42fd-a3f5-4b997d8744c7"),
				CreatedInSchemaUId = new Guid("3aae87d0-c8a8-4cc9-a788-1228f8d4036d"),
				ModifiedInSchemaUId = new Guid("3aae87d0-c8a8-4cc9-a788-1228f8d4036d")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3aae87d0-c8a8-4cc9-a788-1228f8d4036d"));
		}

		#endregion

	}

	#endregion

}

