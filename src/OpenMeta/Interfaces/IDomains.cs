using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OMeta
{
    /// <summary>
    /// This is a MyMeta Collection. The only two methods meant for public consumption are Count and Item.
    /// </summary>
    [Guid("15B1D27B-AB7C-429A-900C-0026571350E7"),InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IDomains : IList, IEnumerable<IDomain>
	{
		// User Meta Data
		string UserDataXPath { get; }

		/// <summary>
		/// You access items in the collect using this method. The return is the object in the collection.
		/// </summary>
		/// <param name="index">Either an integer or a string.
		/// </param>
		[DispId(0)]
		IDomain this[object index] { get; }

		// ICollection
		/// <summary>
		/// ICollection support. Not implemented.
		/// </summary>
		new bool IsSynchronized { get; }

		/// <summary>
		/// The number of items in the collection
		/// </summary>
		new int Count { get; }

		/// <summary>
		/// ICollection support. Not implemented.
		/// </summary>
		new void CopyTo(System.Array array, int index);

		/// <summary>
		/// ICollection support. Not implemented.
		/// </summary>
		new object SyncRoot { get; }
	}
}

