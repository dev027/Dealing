// <copyright file="SetFactory.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Deal.Domain.DomainObjects.Owners;
using Deal.Domain.DomainObjects.SetColours;
using Deal.Domain.DomainObjects.SetPurposes;
using Deal.Domain.DomainObjects.Sets;
using Deal.Domain.Exceptions;
using Deal.Domain.Resources;

namespace Deal.Domain.DomainFactories.Sets
{
    /// <summary>
    /// Factory for creating Sets.
    /// </summary>
    /// <seealso cref="ISetFactory" />
    public class SetFactory : ISetFactory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetFactory"/> class.
        /// </summary>
        /// <param name="owners">Owners.</param>
        /// <param name="setPurposes">Set Purposes.</param>
        /// <param name="setColours">Set Colours.</param>
        public SetFactory(
            IList<IOwner> owners,
            IList<ISetPurpose> setPurposes,
            IList<ISetColour> setColours)
        {
            this.Owners = owners;
            this.SetPurposes = setPurposes;
            this.SetColours = setColours;
        }

        private IList<IOwner> Owners { get; }

        private IList<ISetPurpose> SetPurposes { get; }

        private IList<ISetColour> SetColours { get; }

        /// <inheritdoc/>
        public ISet Create32BoardSet(
            string ownerCode,
            string setPurposeCode,
            string setColourCode,
            string description)
        {
            IOwner owner = this.GetOwner(ownerCode);
            ISetPurpose setPurpose = this.GetSetPurpose(setPurposeCode);
            ISetColour setColour = this.GetSetColour(setColourCode);

            return new Set(
                id: Guid.NewGuid(),
                lowBoardNumber: 1,
                highBoardNumber: 32,
                description: description,
                owner: owner,
                setPurpose: setPurpose,
                setColour: setColour);
        }

        private IOwner GetOwner(string ownerCode)
        {
            return this.Owners
                       .SingleOrDefault(sp => sp.Code == ownerCode)
                   ?? throw new SetFactoryException(
                       string.Format(
                           CultureInfo.InvariantCulture,
                           ExceptionResource.CannotFind___WithCode___,
                           "Owner",
                           ownerCode));
        }

        private ISetPurpose GetSetPurpose(string setPurposeCode)
        {
            return this.SetPurposes
                       .SingleOrDefault(sp => sp.Code == setPurposeCode)
                   ?? throw new SetFactoryException(
                       string.Format(
                           CultureInfo.InvariantCulture,
                           ExceptionResource.CannotFind___WithCode___,
                           "SetPurpose",
                           setPurposeCode));
        }

        private ISetColour GetSetColour(string setColourCode)
        {
            return this.SetColours
                       .SingleOrDefault(sc => sc.Code == setColourCode)
                   ?? throw new SetFactoryException(
                       string.Format(
                           CultureInfo.InvariantCulture,
                           ExceptionResource.CannotFind___WithCode___,
                           "SetColour",
                           setColourCode));
        }
    }
}