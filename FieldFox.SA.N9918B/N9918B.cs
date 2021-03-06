﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using OpenTap;

//Note this template assumes that you have a SCPI based instrument, and accordingly
//extends the ScpiInstrument base class.

//If you do NOT have a SCPI based instrument, you should modify this instance to extend
//the (less powerful) Instrument base class.

namespace FieldFox.SA.N9918B
{
	[Display("N9918B", Group: "FieldFox.SA.N9918B", Description: "Insert a description here")]
	public class N9918B : ScpiInstrument
	{
		#region Settings
		// ToDo: Add property here for each parameter the end user should be able to change
		#endregion

		public N9918B()
		{
			Name = "MyINST";
			// ToDo: Set default values for properties / settings.
		}

		/// <summary>
		/// Open procedure for the instrument.
		/// </summary>
		public override void Open()
		{

			base.Open();
			// TODO:  Open the connection to the instrument here

			//if (!IdnString.Contains("Instrument ID"))
			//{
			//    Log.Error("This instrument driver does not support the connected instrument.");
			//    throw new ArgumentException("Wrong instrument type.");
			// }

		}

		/// <summary>
		/// Close procedure for the instrument.
		/// </summary>
		public override void Close()
		{
			// TODO:  Shut down the connection to the instrument here.
			base.Close();
		}
	}
}
