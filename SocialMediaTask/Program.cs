// See https://aka.ms/new-console-template for more information
using SocialMediaTask;

SocialMedia socialMedia = new();

socialMedia.AddFriend("Revan", "Anar", "Elnur", "ElnurV2", "Abil");

socialMedia.GetAllFriendsByUserName("Revan");