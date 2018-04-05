# XPayBinding
### Binding of the SDK of XPay for Xamarin
Download the binding project, insert the [last](https://ecommerce.nexi.it/area-test) version of the .AAR in the Jars folder and build the solution.
The .dll should be in the /obj folder of your project.

### Integration
In your Application, reference the .dll through right click on References -> Browse -> Path of your .dll

As for the native Android SDK, you have to add the dependencies to your application. 
Luckly we have the nuget packages, we just need to add the packages: Volley and GSON.
