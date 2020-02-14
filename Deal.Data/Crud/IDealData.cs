// <copyright file="IDealData.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;

namespace Deal.Data.Crud
{
    /// <summary>
    /// Data Access Layer.
    /// </summary>
    /// <seealso cref="Deal.Data.Crud.ICreate" />
    /// <seealso cref="Deal.Data.Crud.IReadAny" />
    /// <seealso cref="System.IDisposable" />
    public interface IDealData
        : ICreate, IReadAny, IDisposable
    {
    }
}