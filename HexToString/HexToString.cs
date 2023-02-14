namespace Utils
{
	public static class HexToString
	{
		public static bool ConvertTo(string hexStr, out byte[]? bytes)
		{
			bytes = null;
			if (null == hexStr)
			{
				return false;
			}
			int bytesLen = (int)Math.Ceiling(hexStr.Length * 0.5);
			bytes = new byte[((bytesLen > 0) ? bytesLen : 1)];
			for (int i = 0; i < bytesLen; ++i)
			{
				bytes[i] = Convert.ToByte(hexStr.Substring(i * 2, 2), 16);
			}

			return true;
		}
	}
}