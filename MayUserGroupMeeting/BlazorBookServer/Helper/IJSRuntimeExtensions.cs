namespace BlazorServer.Helper
{
	public static class IJSRuntimeExtensions
	{
		public static async ValueTask ToastrSuccess(this IJSRuntime jsRuntime, string message)
		{
			await jsRuntime.InvokeVoidAsync("ShowToastr", "success", message);
		}

		public static async ValueTask ToastrError(this IJSRuntime jsRunTime, string message)
		{
			await jsRunTime.InvokeVoidAsync("ShowToastr", "error", message);
		}

	}
}