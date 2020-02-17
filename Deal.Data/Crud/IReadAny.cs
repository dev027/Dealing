// <copyright file="IReadAny.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

namespace Deal.Data.Crud
{
    /// <summary>
    /// Check table for contents.
    /// </summary>
    public interface IReadAny
    {
        /// <summary>
        /// Check if Cards has any rows.
        /// </summary>
        /// <returns>True if Cards has rows; otherwise False.</returns>
        bool AnyCard();

        /// <summary>
        /// Check if Error reason has any rows.
        /// </summary>
        /// <returns>True if Error Reason has rows; otherwise False.</returns>
        bool AnyErrorReason();

        /// <summary>
        /// Check if Error Reason Groups has any rows.
        /// </summary>
        /// <returns>True if Error Reason Groups has rows; otherwise False.</returns>
        bool AnyErrorReasonGroup();

        /// <summary>
        /// Check if Pack Colours has any rows.
        /// </summary>
        /// <returns>True if Pack Colours has rows; otherwise False.</returns>
        bool AnyPackColour();

        /// <summary>
        /// Check if Ranks has any rows.
        /// </summary>
        /// <returns>True if Ranks has rows; otherwise False.</returns>
        bool AnyRank();

        /// <summary>
        /// Check if Set Colours has any rows.
        /// </summary>
        /// <returns>True if Set Colours has rows; otherwise False.</returns>
        bool AnySetColours();

        /// <summary>
        /// Check if Set Purposes has any rows.
        /// </summary>
        /// <returns>True if Set Purposes has rows; otherwise False.</returns>
        bool AnySetPurpose();

        /// <summary>
        /// Check if Suits has any rows.
        /// </summary>
        /// <returns>True if Suits has rows; otherwise False.</returns>
        bool AnySuit();
    }
}