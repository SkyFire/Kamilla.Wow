using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kamilla.Network.Protocols.Wow.Game
{
    public enum MailType
    {
        Normal = 0,
        Auction = 2,
        Creature = 3,
        GameObject = 4,
        Item = 5,
    }

    public enum MailStationery
    {
        MAIL_STATIONERY_TEST    = 1,
        MAIL_STATIONERY_DEFAULT = 41,
        MAIL_STATIONERY_GM      = 61,
        MAIL_STATIONERY_AUCTION = 62,
        MAIL_STATIONERY_VAL     = 64,
        MAIL_STATIONERY_CHR     = 65,
        MAIL_STATIONERY_ORP     = 67,                           // new in 3.2.2
    }

    /// <summary>
    /// Indicates mail flags.
    /// </summary>
    [Flags]
    public enum MailFlags
    {
        /// <summary>
        /// Nothing.
        /// </summary>
        None        = 0x00,
        /// <summary>
        /// This mail was read.
        /// </summary>
        Read        = 0x01,
        /// <summary>
        /// This mail was returned. Not allow return mail.
        /// </summary>
        Returned    = 0x02,
        /// <summary>
        /// Not allow to make item copy from mail text.
        /// </summary>
        CannotCopy  = 0x04,
        /// <summary>
        /// The receiver must pay money to get this mail.
        /// </summary>
        COD         = 0x08,
        /// <summary>
        /// This mail has body text.
        /// </summary>
        HasBody     = 0x10,
    }

    public enum MailResponseType
    {
        MAIL_SEND = 0,
        MAIL_MONEY_TAKEN = 1,
        MAIL_ITEM_TAKEN = 2,
        MAIL_RETURNED_TO_SENDER = 3,
        MAIL_DELETED = 4,
        MAIL_MADE_PERMANENT = 5
    }

    public enum MailResponseResult
    {
        MAIL_OK = 0,
        MAIL_ERR_EQUIP_ERROR = 1,
        MAIL_ERR_CANNOT_SEND_TO_SELF = 2,
        MAIL_ERR_NOT_ENOUGH_MONEY = 3,
        MAIL_ERR_RECIPIENT_NOT_FOUND = 4,
        MAIL_ERR_NOT_YOUR_TEAM = 5,
        MAIL_ERR_INTERNAL_ERROR = 6,
        MAIL_ERR_DISABLED_FOR_TRIAL_ACC = 14,
        MAIL_ERR_RECIPIENT_CAP_REACHED = 15,
        MAIL_ERR_CANT_SEND_WRAPPED_COD = 16,
        MAIL_ERR_MAIL_AND_CHAT_SUSPENDED = 17,
        MAIL_ERR_TOO_MANY_ATTACHMENTS = 18,
        MAIL_ERR_MAIL_ATTACHMENT_INVALID = 19,
        MAIL_ERR_ITEM_HAS_EXPIRED = 21,
    }
}
