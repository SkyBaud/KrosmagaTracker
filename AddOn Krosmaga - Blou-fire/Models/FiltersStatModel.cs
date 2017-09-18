﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddOn_Krosmaga___Blou_fire.Enums;
using AddOn_Krosmaga___Blou_fire.Helpers;

namespace AddOn_Krosmaga___Blou_fire.Models
{
	public class FiltersStatModel : ObservableObject
	{
		private SaisonsEnum _selectedSaison;
		private ClassEnum _selectedClass;
		private ClassEnum _selectedVsClass;

		public FiltersStatModel()
		{
			
		}
		public FiltersStatModel(SaisonsEnum selectedSaison, ClassEnum selectedClass, ClassEnum selectedVsClass)
		{
			SelectedSaison = selectedSaison;
			SelectedClass = selectedClass;
			SelectedVsClass = selectedVsClass;
		}

		#region Properties

		public SaisonsEnum SelectedSaison
		{
			get { return _selectedSaison; }
			set
			{
				_selectedSaison = value;
				OnPropertyChanged("SelectedSaison");
			}
		}

		public ClassEnum SelectedClass
		{
			get { return _selectedClass; }
			set
			{
				_selectedClass = value;
				OnPropertyChanged("SelectedClass");
			}
		}

		public ClassEnum SelectedVsClass
		{
			get { return _selectedVsClass; }
			set
			{
				_selectedVsClass = value;
				OnPropertyChanged("SelectedVsClass");
			}
		}

		#endregion
	}
}