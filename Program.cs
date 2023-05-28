// See https://aka.ms/new-console-template for more information
using EnumPOC.Extension;
using static EnumPOC.CommonEnum;

//Get enum value
int roleId = Role.Admin.ToInt();

//get enum key string
string enumName = Role.Manager.ToString();

//get enum description
string desc = Role.User.ToDescription();

//get enum from value
Role role = roleId.GetEnum<Role>();

//get enum from key
Role role2 = enumName.GetEnum<Role>();

//get list of names of all item in enum
List<string> names = EnumExtension.GetNameListOfEnum<Role>();
//get list of description of all item in enum
List<string> values = EnumExtension.GetDescriptionListOfEnum<Role>();

//check value exists in enum
var isExist = 8.isEnunExist<Role>();
var isExist1 = 1.isEnunExist<Role>();

//check key exists in enum
var isExist2 = "test".isEnunExist<Role>();
var isExist3 = enumName.isEnunExist<Role>();



Console.WriteLine("Hello, World!");
