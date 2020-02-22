// <copyright file="ISetFactory.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using Deal.Domain.DomainObjects.Sets;

namespace Deal.Domain.DomainFactories.Sets
{
    /// <summary>
    /// Set Factory.
    /// </summary>
    public interface ISetFactory
    {
        /// <summary>
        /// Create a set of 32 boards, number 1 to 32.
        /// </summary>
        /// <param name="ownerCode">Owner Code.</param>
        /// <param name="setPurposeCode">Set Purpose Code.</param>
        /// <param name="setColourCode">Set Colour Code.</param>
        /// <param name="description">Set Description.</param>
        /// <returns>Set.</returns>
        ISet Create32BoardSet(
            string ownerCode,
            string setPurposeCode,
            string setColourCode,
            string description);
    }
}