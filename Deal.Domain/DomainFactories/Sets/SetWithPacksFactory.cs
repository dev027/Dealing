// <copyright file="SetWithPacksFactory.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Deal.Domain.DomainObjects.Owners;
using Deal.Domain.DomainObjects.PackColours;
using Deal.Domain.DomainObjects.Packs;
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
    /// <seealso cref="ISetWithPacksFactory" />
    public class SetWithPacksFactory : ISetWithPacksFactory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetWithPacksFactory"/> class.
        /// </summary>
        /// <param name="owners">Owners.</param>
        /// <param name="packColours">Pack Colours.</param>
        /// <param name="setPurposes">Set Purposes.</param>
        /// <param name="setColours">Set Colours.</param>
        public SetWithPacksFactory(
            IList<IOwner> owners,
            IList<IPackColour> packColours,
            IList<ISetPurpose> setPurposes,
            IList<ISetColour> setColours)
        {
            this.Owners = owners ?? throw new ArgumentNullException(nameof(owners));
            this.PackColours = packColours ?? throw new ArgumentNullException(nameof(packColours));
            this.SetPurposes = setPurposes ?? throw new ArgumentNullException(nameof(setPurposes));
            this.SetColours = setColours ?? throw new ArgumentNullException(nameof(setColours));

            this.RedPackColour = this.GetPackColour("R");
            this.BluePackColour = this.GetPackColour("B");
        }

        private IList<IOwner> Owners { get; }

        private IList<IPackColour> PackColours { get; }

        private IList<ISetPurpose> SetPurposes { get; }

        private IList<ISetColour> SetColours { get; }

        private IPackColour RedPackColour { get; }

        private IPackColour BluePackColour { get; }

        /// <inheritdoc/>
        public ISetWithPacks Create32BoardSet(
            string ownerCode,
            string setPurposeCode,
            string setColourCode,
            string description)
        {
            if (ownerCode == null)
            {
                throw new ArgumentNullException(nameof(ownerCode));
            }

            if (setPurposeCode == null)
            {
                throw new ArgumentNullException(nameof(setPurposeCode));
            }

            if (setColourCode == null)
            {
                throw new ArgumentNullException(nameof(setColourCode));
            }

            IOwner owner = this.GetOwner(ownerCode);
            ISetPurpose setPurpose = this.GetSetPurpose(setPurposeCode);
            ISetColour setColour = this.GetSetColour(setColourCode);

            ISet set = new Set(
                id: Guid.NewGuid(),
                lowBoardNumber: 1,
                highBoardNumber: 32,
                description: description,
                owner: owner,
                setPurpose: setPurpose,
                setColour: setColour);

            IList<IPack> packs = new List<IPack>();
            for (int boardNumber = set.LowBoardNumber; boardNumber <= set.HighBoardNumber; boardNumber++)
            {
                IPack pack = new Pack(
                    id: Guid.NewGuid(),
                    packColour: boardNumber % 2 == 1 ? this.RedPackColour : this.BluePackColour,
                    set: set,
                    enteredService: DateTime.Today,
                    boardNumber: boardNumber);
                packs.Add(pack);
            }

            return new SetWithPacks(set, packs);
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

        private IPackColour GetPackColour(string packColourCode)
        {
            return this.PackColours
                       .SingleOrDefault(sc => sc.Code == packColourCode)
                   ?? throw new SetFactoryException(
                       string.Format(
                           CultureInfo.InvariantCulture,
                           ExceptionResource.CannotFind___WithCode___,
                           "PackColour",
                           packColourCode));
        }
    }
}