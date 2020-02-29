// <copyright file="IDealData.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;

namespace Deal.Data.Crud
{
    /// <summary>
    /// Data Access Layer.
    /// </summary>
    /// <seealso cref="ICreate" />
    /// <seealso cref="IReadAny" />
    /// <seealso cref="IRead" />
    /// <seealso cref="IUpdate" />
    /// <seealso cref="IDisposable" />
    public interface IDealData
        : ICreate, IReadAny, IRead, IUpdate, IDisposable
    {
    }
}