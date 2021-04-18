﻿using PlayerList.Config;

namespace PlayerList.Entries
{
    class LeftSidePlayerEntry : EntryBase
    {
        public override void Init(object[] parameters = null)
        {
            OnConfigChanged();
        }
        public override void OnConfigChanged()
        {
            if (!PlayerListConfig.numberedList.Value)
                if (!PlayerListConfig.condensedText.Value)
                    textComponent.text = " - ";
                else
                    textComponent.text = "-";
            else
                CalculateLeftPart();
        }

        public void CalculateLeftPart()
        {
            if (PlayerListConfig.numberedList.Value)
                if (PlayerListConfig.condensedText.Value)
                    textComponent.text = $"{gameObject.transform.parent.GetSiblingIndex() - 1}.".PadRight((gameObject.transform.parent.parent.childCount - 2).ToString().Length + 1); // Pad by weird amount because we cant include the header and disabled template in total number of gameobjects
                else
                    textComponent.text = $"{gameObject.transform.parent.GetSiblingIndex() - 1}. ".PadRight((gameObject.transform.parent.parent.childCount - 2).ToString().Length + 2);
        }
    }
}
