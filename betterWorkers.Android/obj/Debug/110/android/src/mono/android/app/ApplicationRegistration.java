package mono.android.app;

public class ApplicationRegistration {

	public static void registerApplications ()
	{
				// Application and Instrumentation ACWs must be registered first.
		mono.android.Runtime.register ("MainApplication, betterWorkers.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", crc64eebbc1b7e09f74a3.MainApplication.class, crc64eebbc1b7e09f74a3.MainApplication.__md_methods);
		
	}
}
