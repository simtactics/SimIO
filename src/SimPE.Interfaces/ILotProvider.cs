/***************************************************************************
 *   Copyright (C) 2005 by Ambertation                                     *
 *   quaxi@ambertation.de                                                  *
 *                                                                         *
 *   This program is free software; you can redistribute it and/or modify  *
 *   it under the terms of the GNU General Public License as published by  *
 *   the Free Software Foundation; either version 2 of the License, or     *
 *   (at your option) any later version.                                   *
 *                                                                         *
 *   This program is distributed in the hope that it will be useful,       *
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of        *
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the         *
 *   GNU General Public License for more details.                          *
 *                                                                         *
 *   You should have received a copy of the GNU General Public License     *
 *   along with this program; if not, write to the                         *
 *   Free Software Foundation, Inc.,                                       *
 *   59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.             *
 ***************************************************************************/

using System;
using System.Collections;
using System.Drawing;
using SimPe.Interfaces.Scenegraph;

namespace SimPe.Interfaces.Providers
{
	public interface ILotItem
	{
		uint Instance
		{
			get;
		}

		Image Image
		{
			get;
		}

		string Name
		{
			get;
		}

		string LotName
		{
			get;
		}
			


		object FindTag(Type t);
		ArrayList Tags
		{
			get;
		}

		uint Owner
		{
			get;
		}

		IScenegraphFileIndexItem LtxtFileIndexItem
		{
			get;
		}

		IScenegraphFileIndexItem BnfoFileIndexItem
		{
			get;
		}

		IScenegraphFileIndexItem StrFileIndexItem
		{
			get;
		}

	}

	public delegate void LoadLotData(object sender, ILotItem item);

	/// <summary>
	/// Interface to obtain Lot Informations
	/// </summary>
	public interface ILotProvider
	{
		/// <summary>
		/// Returns or sets the Folder where the Character Files are stored
		/// </summary>
		/// <remarks>Sets the names List to null</remarks>
		string BaseFolder
		{
			get; set;
		}

		/// <summary>
		/// returns a List of all Lot Names
		/// </summary>
		/// <returns></returns>
		string[] GetNames();

		Hashtable StoredData
		{
			get;
		}

		ILotItem FindLot(uint inst);
		ILotItem[] FindLotsOwnedBySim(uint siminst);

		event LoadLotData LoadingLot;
		
	}
}
