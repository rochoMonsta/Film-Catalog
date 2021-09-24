using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FilmCatalog.Models
{
    public enum FriendsRelationshipStatus
    {
        Pending = 1,
        AcceptInvite
    }

    public class Friends : DomainObject
    {
        private int _firstUserId;
        private int _secondUserId;
        //private User _firstUser;
        //private User _secondUser;
        private int _friendsRelationshipStatus;

        public int FirstUserId
        {
            get => _firstUserId;
            set => Set(ref _firstUserId, value);
        }

        public int SecondUserId
        {
            get => _secondUserId;
            set => Set(ref _secondUserId, value);
        }

        //public User FirstUser
        //{
        //    get => _firstUser;
        //    set => Set(ref _firstUser, value);
        //}

        //public User SecondUser
        //{
        //    get => _secondUser;
        //    set => Set(ref _secondUser, value);
        //}

        public int FriendsRelationshipStatus
        {
            get => _friendsRelationshipStatus;
            set => Set(ref _friendsRelationshipStatus, value);
        }
    }
}
