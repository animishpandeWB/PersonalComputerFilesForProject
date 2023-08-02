// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using EF_Tutorial.Data;
// using EF_Tutorial.Models;

// namespace EF_Tutorial
// {
//     public class Seed
//     {
//         public static async Task SeedDataContext(DataContext context)
//         {
//             if (!context.Users.Any())
//             {
//                 var UsersList = new List<User>() {
//                 new User
//                     {
//                         Username = "Test1",
//                         Email = "test1@123.com",
//                         Password = "test1",
//                         Pumps = {
//                             new Pump {
//                                 Name = "Pump 1",
//                                 Type = "Jet Pump",
//                                 Status = true
//                             },
//                             new Pump {
//                                 Name = "Pump 2",
//                                 Type = "Centrifugal Pump",
//                                 Status = false
//                             },
//                             new Pump {
//                                 Name = "Pump 3",
//                                 Type = "Piston Pump",
//                                 Status = true
//                             },
//                             new Pump {
//                                 Name = "Pump 4",
//                                 Type = "Centrifugal Pump",
//                                 Status = false
//                             },
//                             new Pump {
//                                 Name = "Pump 5",
//                                 Type = "Jet Pump",
//                                 Status = true
//                             },
//                             new Pump {
//                                 Name = "Pump 6",
//                                 Type = "Piston Pump",
//                                 Status = false
//                             },
//                             new Pump {
//                                 Name = "Pump 7",
//                                 Type = "Jet Pump",
//                                 Status = false
//                             },
//                             new Pump {
//                                 Name = "Pump 8",
//                                 Type = "Centrifugal Pump",
//                                 Status = false
//                             },
//                             new Pump {
//                                 Name = "Pump 9",
//                                 Type = "Jet Pump",
//                                 Status = true
//                             },
//                             new Pump {
//                                 Name = "Pump 10",
//                                 Type = "Jet Pump",
//                                 Status = false
//                             },
//                             new Pump {
//                                 Name = "Pump 11",
//                                 Type = "Piston Pump",
//                                 Status = false
//                             },
//                             new Pump {
//                                 Name = "Pump 12",
//                                 Type = "Piston Pump",
//                                 Status = true
//                             },
//                             new Pump {
//                                 Name = "Pump 13",
//                                 Type = "Centrifugal Pump",
//                                 Status = true
//                             },
//                             new Pump {
//                                 Name = "Pump 14",
//                                 Type = "Jet Pump",
//                                 Status = false
//                             },
//                             new Pump {
//                                 Name = "Pump 15",
//                                 Type = "Piston Pump",
//                                 Status = false
//                             },
//                             new Pump {
//                                 Name = "Pump 16",
//                                 Type = "Centrifugal Pump",
//                                 Status = true
//                             },
//                             new Pump {
//                                 Name = "Pump 17",
//                                 Type = "Jet Pump",
//                                 Status = true
//                             },
//                             new Pump {
//                                 Name = "Pump 18",
//                                 Type = "Jet Pump",
//                                 Status = false
//                             },
//                             new Pump {
//                                 Name = "Pump 19",
//                                 Type = "Piston Pump",
//                                 Status = false
//                             },
//                             new Pump {
//                                 Name = "Pump 20",
//                                 Type = "Piston Pump",
//                                 Status = false
//                             },
//                             new Pump {
//                                 Name = "Pump 21",
//                                 Type = "Centrifugal Pump",
//                                 Status = false
//                             },
//                             new Pump {
//                                 Name = "Pump 22",
//                                 Type = "Jet Pump",
//                                 Status = true
//                             },
//                             new Pump {
//                                 Name = "Pump 23",
//                                 Type = "Piston Pump",
//                                 Status = false
//                             },
//                             new Pump {
//                                 Name = "Pump 24",
//                                 Type = "Piston Pump",
//                                 Status = true
//                             },
//                             new Pump {
//                                 Name = "Pump 25",
//                                 Type = "Piston Pump",
//                                 Status = false
//                             },
//                             new Pump {
//                                 Name = "Pump 26",
//                                 Type = "Jet Pump",
//                                 Status = false
//                             },
//                             new Pump {
//                                 Name = "Pump 27",
//                                 Type = "Centrifugal Pump",
//                                 Status = true
//                             },
//                             new Pump {
//                                 Name = "Pump 28",
//                                 Type = "Jet Pump",
//                                 Status = true
//                             },
//                             new Pump {
//                                 Name = "Pump 29",
//                                 Type = "Piston Pump",
//                                 Status = false
//                             },
//                             new Pump {
//                                 Name = "Pump 30",
//                                 Type = "Piston Pump",
//                                 Status = true
//                             }
//                         }
//                     },
                
//                 };
//                 await context.Users.AddRangeAsync(UsersList);
//                 await context.SaveChangesAsync();
//             }
//         }
//     }
// }