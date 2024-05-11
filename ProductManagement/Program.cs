internal class Program
{
	private static void Main(string[] args)
	{
		string[,] Users = new string[5, 4];
		bool[] isBlokced = new bool[5];
		Users[0, 0] = "admin";
		Users[0, 1] = "admin";
		isBlokced[0] = false;
		Console.Clear();
	retry:

		Console.WriteLine("================================================");
		Console.WriteLine("============ Welcome to the system =============");
		Console.WriteLine("================================================\n");
		Console.WriteLine("Please enter your username");
		Console.Write("Username: ");
		string userNameInput = Console.ReadLine();
		int i = 0;
		while (i < 5)
		{
			if (userNameInput == Users[i, 0])
			{
				Console.WriteLine("Username is correct");
				Console.WriteLine("\n================================================\n");
				break;
			}
			if (i == 4)
			{
				Console.WriteLine("there is no such username in the system");
				Console.WriteLine("\n================================================\n");
				goto retry;
			}
			i++;
		}
		int j = 0;
		while (j < 3)
		{
			Console.WriteLine("Please enter your password");
			Console.Write("Password: ");
			string passwordInput = Console.ReadLine();

			if (userNameInput == Users[i, 0] && passwordInput == Users[i, 1])
			{
				if (isBlokced[i] == false)
				{
					Console.WriteLine("You have successfully logged in");
					break;
				}
				else
				{
					Console.WriteLine("your account is blocked");
					goto retry;
				}
			}
			else
			{
				Console.WriteLine("password is incorrect please try again");
				Console.WriteLine("you have " + (2 - j) + " attempts left");
				j++;
				Users[i, 3] = j + " wrong attempts";
			}
		}//------------
		if (j == 3)
		{
			Console.WriteLine("Your account has been blocked due \nto multiple login attempts try again \nwith a different username\n");
			isBlokced[i] = true;
			goto retry;
		}
		string[,] products = new string[20, 5];
		Console.Clear();
	list:
		Console.WriteLine("\n================================================");
		Console.WriteLine("============ Welcome to the system =============");
		Console.WriteLine("================================================\n");
		Console.WriteLine("1 List of Products");
		Console.WriteLine("2 Add Product");
		Console.WriteLine("3 Delete Product");
		Console.WriteLine("4 Details of Product");
		Console.WriteLine("5 User List");
		Console.WriteLine("6 Add User");
		Console.WriteLine("7 Details of User");
		Console.WriteLine("0 Exit");
		Console.Write("Please select an option: ");
		int option = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("You have selected option: " + option);
		switch (option)
		{
			case 1:
				Console.Clear();
				Console.WriteLine("================================================");
				Console.WriteLine("=============== List of products ===============");
				Console.WriteLine("================================================\n");
				int l = 0;
				if (products[0, 0] == null)
				{
					Console.WriteLine("There is no product in the system yet\ntry adding one with option 2\n");
					break;
				}
				while (l < 20)
				{
					if (products[l, 0] != null)
					{
						Console.WriteLine("Product " + (l + 1) + " = " + products[l, 0]);
					}
					l++;
				}
				break;
			case 2:
				Console.Clear();
				Console.WriteLine("================================================");
				Console.WriteLine("================== Add Product =================");
				Console.WriteLine("================================================\n");
				Console.Write("Please enter the product name :");
				string productName = Console.ReadLine();
				Console.Write("Please enter the product price :");
				string productPrice = Console.ReadLine();
				Console.Write("Please enter the product stock :");
				string productStock = Console.ReadLine();
				Console.Write("Please enter the product description :");
				string productDescription = Console.ReadLine();

				for (int k = 0; k < 20; k++)
				{
					if (products[k, 0] == null)
					{
						products[k, 0] = productName;
						products[k, 1] = productPrice;
						products[k, 2] = productStock;
						products[k, 3] = productDescription;
						Console.WriteLine("Product added successfully");
						break;
					}
				}
				break;
			case 3:
				Console.Clear();
				Console.WriteLine("================================================");
				Console.WriteLine("================ Delete Product ================");
				Console.WriteLine("================================================\n");
				Console.WriteLine("Please enter the product name");
				string productDelete = Console.ReadLine();
				for (int k = 0; k < 20; k++)
				{
					if (products[k, 0] == productDelete)
					{
						products[k, 0] = null;
						products[k, 1] = null;
						products[k, 2] = null;
						products[k, 3] = null;
						Console.WriteLine("Product deleted successfully");
						break;
					}
				}
				break;
			case 4:
				Console.Clear();
				Console.WriteLine("================================================");
				Console.WriteLine("============== Details of Product ==============");
				Console.WriteLine("================================================\n");
				Console.Write("Please enter the product name : ");
				string product = Console.ReadLine();
				for (int k = 0; k < 20; k++)
				{
					if (products[k, 0] == product)
					{
						Console.WriteLine("Product Name: " + products[k, 0]);
						Console.WriteLine("Product Price: " + products[k, 1]);
						Console.WriteLine("Product Stock: " + products[k, 2]);
						Console.WriteLine("Product Description: " + products[k, 3]);
						break;
					}
				}
				break;
			case 5:
				Console.Clear();
				Console.WriteLine("================================================");
				Console.WriteLine("=================== User List ==================");
				Console.WriteLine("================================================\n");
				int m = 0;
				while (m < 5)
				{
					if (Users[m, 0] != null)
					{
						Console.WriteLine("Username: " + Users[m, 0]);
					}
					m++;
				}
				break;
			case 6:
				Console.Clear();
				Console.WriteLine("================================================");
				Console.WriteLine("=================== Add User ===================");
				Console.WriteLine("================================================\n");

				Console.WriteLine("Please enter the username");
				Console.Write("Username: ");
				string username = Console.ReadLine();
				Console.WriteLine("Please enter the Email");
				Console.Write("Email: ");
				string email = Console.ReadLine();
				Console.WriteLine("Please enter the password");
				Console.Write("Password: ");
				string password = Console.ReadLine();

				for (int k = 0; k < 5; k++)
				{
					if (Users[k, 0] == null)
					{
						Users[k, 0] = username;
						Users[k, 1] = password;
						Users[k, 2] = email;
						Users[k, 3] = "0 wrong attempts";
						Console.WriteLine("User added successfully");
						break;
					}
				}
				break;
			case 7:
				Console.Clear();
				Console.WriteLine("================================================");
				Console.WriteLine("================ Details of User ===============");
				Console.WriteLine("================================================\n");

				Console.Write("Please enter the username : ");
				string user = Console.ReadLine();
				for (int k = 0; k < 5; k++)
				{
					if (Users[k, 0] == user)
					{
						Console.WriteLine("Username: " + Users[k, 0]);
						Console.WriteLine("Email: " + Users[k, 2]);
						Console.WriteLine("Password: " + Users[k, 1]);
						Console.WriteLine("Wrong attempts: " + Users[k, 3]);
						break;
					}
				}
				break;
			case 0:
				Console.Clear();
				Console.WriteLine("================================================");
				Console.WriteLine("================== Exit screen =================");
				Console.WriteLine("================================================\n");
				Console.WriteLine("Do you want to exit from the system or log out?");
				Console.WriteLine("1 Exit");
				Console.WriteLine("2 Log out");
				Console.Write("Please select an option: ");
				int exitOption = Convert.ToInt32(Console.ReadLine());
				if (exitOption == 1)
				{
					Console.Clear();
					Console.WriteLine("You have successfully exited from the system");
					Console.WriteLine("================================================\n");

					goto exit;
				}
				else if (exitOption == 2)
				{
					Console.Clear();
					Console.WriteLine("You have successfully logged out from the system");
					Console.WriteLine("================================================\n");

					goto retry;
				}
				break;
			default:
				Console.WriteLine("Invalid option");
				Console.WriteLine("================================================\n");

				break;
		}
		goto list;
	exit:;
	}
}