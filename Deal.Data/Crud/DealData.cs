// <copyright file="DealData.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using Deal.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Deal.Data.Crud
{
    /// <summary>
    /// Data access layer.
    /// </summary>
    /// <seealso cref="Deal.Data.Crud.IDealData" />
    public partial class DealData : IDealData
    {
        /// <summary>
        /// Indicates if resources have been disposed.
        /// </summary>
        private bool isDisposed;

        /// <summary>
        /// Initializes a new instance of the <see cref="DealData"/> class.
        /// </summary>
        public DealData()
        {
            this.Context = new DataContext();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DealData"/> class.
        /// </summary>
        /// <param name="options">Database context options.</param>
        public DealData(DbContextOptions<DataContext> options)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            this.Context = new DataContext(options);
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="DealData"/> class.
        /// </summary>
        ~DealData()
        {
            this.Dispose(false);
        }

        /// <summary>
        /// Gets or sets the Database Context.
        /// </summary>
        private DataContext Context { get; set; }

        /// <inheritdoc/>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (this.isDisposed)
            {
                return;
            }

            if (disposing)
            {
            }

            this.Context.Dispose();

            this.isDisposed = true;
        }
    }
}