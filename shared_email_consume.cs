//Create a service
ExchangeService service = new ExchangeService(ExchangeVersion.Exchange2007_SP1);
//Autodiscover end point
service.AutodiscoverUrl("someaddress@mycompany.com");

//Shared mailbox name
FolderId SharedMailbox = new FolderId(WellKnownFolderName.Inbox,"Shared@domain.com");

ItemView itemView = new ItemView(1000);

 FindFoldersResults folderSearchResults = service.FindItems(SharedMailbox,itemView);
