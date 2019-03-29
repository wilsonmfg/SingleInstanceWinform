# Single Instance WinForms Example

## Setup steps:
First decide which form in your project will receive the single instance signals.  This does not need to be your main interface, but will need to have an active instance throughout your app's lifetime.  Closing this form will shut down your program.  In this example we'll use a form named `MainForm`.

1. Add `SingleAppContext.cs` to your WinForms project
2. Add `System.Runtime.Remoting` to your project References.
3. Edit `MainForm.cs` (not `MainForm.Designer.cs`) and change `public partial class MainForm : Form` to `public partial class MainForm : SingleInstanceWinform.FormSingleInstance`
4. Add a `SignalExternalCommandLineArgs` override to the form code, example below.
5. Change the `Application.Run` in `Program.cs` as per below.

### Using ApplicationContext
The default for a WinForm is to run a form via `Application.Run(new Form1());`.  To make Single Instance work we need to switch to an `ApplicationContext` startup.  Change the Run line to:

	Application.Run(new SingleInstanceWinform.SingleAppContext(new MainForm(), "SingleInstanceWinform"));
    
The 2nd paramater, "SingleInstanceWinform", is a unique identifer for your application. It is used to create an IPC channel, so choose this name such that it will not collide with any other apps you might run.

### Handling the Signal
When a second instance of your program is started, your first instance will recieve a signal that includes any command line arguments that were passed.  To handle this signal we need to add an override for the `SignalExternalCommandLineArgs` method to the form.

To simlpy bring the form to the front:

	public override bool SignalExternalCommandLineArgs(IList<string> args)
	{
        //Method is called from a different thread so Invoke on the form's UI thread to interact with it
        this.Invoke((Action)delegate
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            this.Activate();
        });
        return true;
	}

Returning `false` from this method will allow another instance of the application to be started, but this will break the IPC channel in the current implementation.

## License
[Microsoft Public License (MS-PL)](https://opensource.org/licenses/ms-pl.html)

This is based heavily on SingleInstance.cs from Miscrosoft which is also MS-PL.