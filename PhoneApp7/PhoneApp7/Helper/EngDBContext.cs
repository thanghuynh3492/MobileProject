#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhoneApp7
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
using System.IO;
using System.IO.IsolatedStorage;
using Microsoft.Phone.Data.Linq.Mapping;
using Microsoft.Phone.Data.Linq;


public class DebugWriter : TextWriter
{
    private const int DefaultBufferSize = 256;
    private System.Text.StringBuilder _buffer;

    public DebugWriter()
    {
        BufferSize = 256;
        _buffer = new System.Text.StringBuilder(BufferSize);
    }

    public int BufferSize
    {
        get;
        private set;
    }

    public override System.Text.Encoding Encoding
    {
        get { return System.Text.Encoding.UTF8; }
    }

    #region StreamWriter Overrides
    public override void Write(char value)
    {
        _buffer.Append(value);
        if (_buffer.Length >= BufferSize)
            Flush();
    }

    public override void WriteLine(string value)
    {
        Flush();

        using(var reader = new StringReader(value))
        {
            string line; 
            while( null != (line = reader.ReadLine()))
                System.Diagnostics.Debug.WriteLine(line);
        }
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
            Flush();
    }

    public override void Flush()
    {
        if (_buffer.Length > 0)
        {
            System.Diagnostics.Debug.WriteLine(_buffer);
            _buffer.Clear();
        }
    }
    #endregion
}


	public partial class EngDBContext : System.Data.Linq.DataContext
	{
		
		public bool CreateIfNotExists()
		{
			bool created = false;
			if (!this.DatabaseExists())
			{
				string[] names = this.GetType().Assembly.GetManifestResourceNames();
				string name = names.Where(n => n.EndsWith(FileName)).FirstOrDefault();
				if (name != null)
				{
					using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name))
					{
						if (resourceStream != null)
						{
							using (IsolatedStorageFile myIsolatedStorage = IsolatedStorageFile.GetUserStoreForApplication())
							{
								using (IsolatedStorageFileStream fileStream = new IsolatedStorageFileStream(FileName, FileMode.Create, myIsolatedStorage))
								{
									using (BinaryWriter writer = new BinaryWriter(fileStream))
									{
										long length = resourceStream.Length;
										byte[] buffer = new byte[32];
										int readCount = 0;
										using (BinaryReader reader = new BinaryReader(resourceStream))
										{
											// read file in chunks in order to reduce memory consumption and increase performance
											while (readCount < length)
											{
												int actual = reader.Read(buffer, 0, buffer.Length);
												readCount += actual;
												writer.Write(buffer, 0, actual);
											}
										}
									}
								}
							}
							created = true;
						}
						else
						{
							this.CreateDatabase();
							created = true;
						}
					}
				}
				else
				{
					this.CreateDatabase();
					created = true;
				}
			}
			return created;
		}
		
		public bool LogDebug
		{
			set
			{
				if (value)
				{
					this.Log = new DebugWriter();
				}
			}
		}
		
		public static string ConnectionString = "Data Source=isostore:/EngDB.sdf";

		public static string ConnectionStringReadOnly = "Data Source=appdata:/EngDB.sdf;File Mode=Read Only;";

		public static string FileName = "EngDB.sdf";

		public EngDBContext(string connectionString) : base(connectionString)
		{
			OnCreated();
		}
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEngLish(EngLish instance);
    partial void UpdateEngLish(EngLish instance);
    partial void DeleteEngLish(EngLish instance);
    partial void InsertEngStudy3(EngStudy3 instance);
    partial void UpdateEngStudy3(EngStudy3 instance);
    partial void DeleteEngStudy3(EngStudy3 instance);
    partial void InsertEngUnit(EngUnit instance);
    partial void UpdateEngUnit(EngUnit instance);
    partial void DeleteEngUnit(EngUnit instance);
    #endregion
		
		public System.Data.Linq.Table<EngLish> EngLish
		{
			get
			{
				return this.GetTable<EngLish>();
			}
		}
		
		public System.Data.Linq.Table<EngStudy3> EngStudy3
		{
			get
			{
				return this.GetTable<EngStudy3>();
			}
		}
		
		public System.Data.Linq.Table<EngUnit> EngUnit
		{
			get
			{
				return this.GetTable<EngUnit>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute()]
	public partial class EngLish : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _Unit;
		
		private string _TextEng;
		
		private string _TextVie;
		
		private string _Image;
		
		private string _SoundEng;
		
		private string _SoundVie;
		
		private string _Answer1;
		
		private string _Answer2;
		
		private string _Answer3;
		
		private string _Answer4;
		
		private int _AS;
		
		private string _ASImage1;
		
		private string _ASImage2;
		
		private string _ASImage3;
		
		private string _ASImage4;
		
		private string _SoundAS1;
		
		private string _SoundAS2;
		
		private string _SoundAS3;
		
		private string _SoundAS4;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnUnitChanging(int value);
    partial void OnUnitChanged();
    partial void OnTextEngChanging(string value);
    partial void OnTextEngChanged();
    partial void OnTextVieChanging(string value);
    partial void OnTextVieChanged();
    partial void OnImageChanging(string value);
    partial void OnImageChanged();
    partial void OnSoundEngChanging(string value);
    partial void OnSoundEngChanged();
    partial void OnSoundVieChanging(string value);
    partial void OnSoundVieChanged();
    partial void OnAnswer1Changing(string value);
    partial void OnAnswer1Changed();
    partial void OnAnswer2Changing(string value);
    partial void OnAnswer2Changed();
    partial void OnAnswer3Changing(string value);
    partial void OnAnswer3Changed();
    partial void OnAnswer4Changing(string value);
    partial void OnAnswer4Changed();
    partial void OnASChanging(int value);
    partial void OnASChanged();
    partial void OnASImage1Changing(string value);
    partial void OnASImage1Changed();
    partial void OnASImage2Changing(string value);
    partial void OnASImage2Changed();
    partial void OnASImage3Changing(string value);
    partial void OnASImage3Changed();
    partial void OnASImage4Changing(string value);
    partial void OnASImage4Changed();
    partial void OnSoundAS1Changing(string value);
    partial void OnSoundAS1Changed();
    partial void OnSoundAS2Changing(string value);
    partial void OnSoundAS2Changed();
    partial void OnSoundAS3Changing(string value);
    partial void OnSoundAS3Changed();
    partial void OnSoundAS4Changing(string value);
    partial void OnSoundAS4Changed();
    #endregion
		
		public EngLish()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Unit", DbType="Int NOT NULL")]
		public int Unit
		{
			get
			{
				return this._Unit;
			}
			set
			{
				if ((this._Unit != value))
				{
					this.OnUnitChanging(value);
					this.SendPropertyChanging();
					this._Unit = value;
					this.SendPropertyChanged("Unit");
					this.OnUnitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TextEng", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TextEng
		{
			get
			{
				return this._TextEng;
			}
			set
			{
				if ((this._TextEng != value))
				{
					this.OnTextEngChanging(value);
					this.SendPropertyChanging();
					this._TextEng = value;
					this.SendPropertyChanged("TextEng");
					this.OnTextEngChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TextVie", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TextVie
		{
			get
			{
				return this._TextVie;
			}
			set
			{
				if ((this._TextVie != value))
				{
					this.OnTextVieChanging(value);
					this.SendPropertyChanging();
					this._TextVie = value;
					this.SendPropertyChanged("TextVie");
					this.OnTextVieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this.OnImageChanging(value);
					this.SendPropertyChanging();
					this._Image = value;
					this.SendPropertyChanged("Image");
					this.OnImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoundEng", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string SoundEng
		{
			get
			{
				return this._SoundEng;
			}
			set
			{
				if ((this._SoundEng != value))
				{
					this.OnSoundEngChanging(value);
					this.SendPropertyChanging();
					this._SoundEng = value;
					this.SendPropertyChanged("SoundEng");
					this.OnSoundEngChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoundVie", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string SoundVie
		{
			get
			{
				return this._SoundVie;
			}
			set
			{
				if ((this._SoundVie != value))
				{
					this.OnSoundVieChanging(value);
					this.SendPropertyChanging();
					this._SoundVie = value;
					this.SendPropertyChanged("SoundVie");
					this.OnSoundVieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Answer1", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Answer1
		{
			get
			{
				return this._Answer1;
			}
			set
			{
				if ((this._Answer1 != value))
				{
					this.OnAnswer1Changing(value);
					this.SendPropertyChanging();
					this._Answer1 = value;
					this.SendPropertyChanged("Answer1");
					this.OnAnswer1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Answer2", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Answer2
		{
			get
			{
				return this._Answer2;
			}
			set
			{
				if ((this._Answer2 != value))
				{
					this.OnAnswer2Changing(value);
					this.SendPropertyChanging();
					this._Answer2 = value;
					this.SendPropertyChanged("Answer2");
					this.OnAnswer2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Answer3", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Answer3
		{
			get
			{
				return this._Answer3;
			}
			set
			{
				if ((this._Answer3 != value))
				{
					this.OnAnswer3Changing(value);
					this.SendPropertyChanging();
					this._Answer3 = value;
					this.SendPropertyChanged("Answer3");
					this.OnAnswer3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Answer4", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Answer4
		{
			get
			{
				return this._Answer4;
			}
			set
			{
				if ((this._Answer4 != value))
				{
					this.OnAnswer4Changing(value);
					this.SendPropertyChanging();
					this._Answer4 = value;
					this.SendPropertyChanged("Answer4");
					this.OnAnswer4Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AS", DbType="Int NOT NULL")]
		public int AS
		{
			get
			{
				return this._AS;
			}
			set
			{
				if ((this._AS != value))
				{
					this.OnASChanging(value);
					this.SendPropertyChanging();
					this._AS = value;
					this.SendPropertyChanged("AS");
					this.OnASChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ASImage1", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string ASImage1
		{
			get
			{
				return this._ASImage1;
			}
			set
			{
				if ((this._ASImage1 != value))
				{
					this.OnASImage1Changing(value);
					this.SendPropertyChanging();
					this._ASImage1 = value;
					this.SendPropertyChanged("ASImage1");
					this.OnASImage1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ASImage2", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string ASImage2
		{
			get
			{
				return this._ASImage2;
			}
			set
			{
				if ((this._ASImage2 != value))
				{
					this.OnASImage2Changing(value);
					this.SendPropertyChanging();
					this._ASImage2 = value;
					this.SendPropertyChanged("ASImage2");
					this.OnASImage2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ASImage3", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string ASImage3
		{
			get
			{
				return this._ASImage3;
			}
			set
			{
				if ((this._ASImage3 != value))
				{
					this.OnASImage3Changing(value);
					this.SendPropertyChanging();
					this._ASImage3 = value;
					this.SendPropertyChanged("ASImage3");
					this.OnASImage3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ASImage4", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string ASImage4
		{
			get
			{
				return this._ASImage4;
			}
			set
			{
				if ((this._ASImage4 != value))
				{
					this.OnASImage4Changing(value);
					this.SendPropertyChanging();
					this._ASImage4 = value;
					this.SendPropertyChanged("ASImage4");
					this.OnASImage4Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoundAS1", DbType="NVarChar(100)")]
		public string SoundAS1
		{
			get
			{
				return this._SoundAS1;
			}
			set
			{
				if ((this._SoundAS1 != value))
				{
					this.OnSoundAS1Changing(value);
					this.SendPropertyChanging();
					this._SoundAS1 = value;
					this.SendPropertyChanged("SoundAS1");
					this.OnSoundAS1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoundAS2", DbType="NVarChar(100)")]
		public string SoundAS2
		{
			get
			{
				return this._SoundAS2;
			}
			set
			{
				if ((this._SoundAS2 != value))
				{
					this.OnSoundAS2Changing(value);
					this.SendPropertyChanging();
					this._SoundAS2 = value;
					this.SendPropertyChanged("SoundAS2");
					this.OnSoundAS2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoundAS3", DbType="NVarChar(100)")]
		public string SoundAS3
		{
			get
			{
				return this._SoundAS3;
			}
			set
			{
				if ((this._SoundAS3 != value))
				{
					this.OnSoundAS3Changing(value);
					this.SendPropertyChanging();
					this._SoundAS3 = value;
					this.SendPropertyChanged("SoundAS3");
					this.OnSoundAS3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoundAS4", DbType="NVarChar(100)")]
		public string SoundAS4
		{
			get
			{
				return this._SoundAS4;
			}
			set
			{
				if ((this._SoundAS4 != value))
				{
					this.OnSoundAS4Changing(value);
					this.SendPropertyChanging();
					this._SoundAS4 = value;
					this.SendPropertyChanged("SoundAS4");
					this.OnSoundAS4Changed();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute()]
	public partial class EngStudy3 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _Unit;
		
		private string _Image;
		
		private int _AS;
		
		private string _Answer1;
		
		private string _Answer2;
		
		private string _Answer3;
		
		private string _Answer4;
		
		private string _SoundAS1;
		
		private string _SoundAS2;
		
		private string _SoundAS3;
		
		private string _SoundAS4;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnUnitChanging(int value);
    partial void OnUnitChanged();
    partial void OnImageChanging(string value);
    partial void OnImageChanged();
    partial void OnASChanging(int value);
    partial void OnASChanged();
    partial void OnAnswer1Changing(string value);
    partial void OnAnswer1Changed();
    partial void OnAnswer2Changing(string value);
    partial void OnAnswer2Changed();
    partial void OnAnswer3Changing(string value);
    partial void OnAnswer3Changed();
    partial void OnAnswer4Changing(string value);
    partial void OnAnswer4Changed();
    partial void OnSoundAS1Changing(string value);
    partial void OnSoundAS1Changed();
    partial void OnSoundAS2Changing(string value);
    partial void OnSoundAS2Changed();
    partial void OnSoundAS3Changing(string value);
    partial void OnSoundAS3Changed();
    partial void OnSoundAS4Changing(string value);
    partial void OnSoundAS4Changed();
    #endregion
		
		public EngStudy3()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Unit", DbType="Int NOT NULL")]
		public int Unit
		{
			get
			{
				return this._Unit;
			}
			set
			{
				if ((this._Unit != value))
				{
					this.OnUnitChanging(value);
					this.SendPropertyChanging();
					this._Unit = value;
					this.SendPropertyChanged("Unit");
					this.OnUnitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this.OnImageChanging(value);
					this.SendPropertyChanging();
					this._Image = value;
					this.SendPropertyChanged("Image");
					this.OnImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AS", DbType="Int NOT NULL")]
		public int AS
		{
			get
			{
				return this._AS;
			}
			set
			{
				if ((this._AS != value))
				{
					this.OnASChanging(value);
					this.SendPropertyChanging();
					this._AS = value;
					this.SendPropertyChanged("AS");
					this.OnASChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Answer1", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Answer1
		{
			get
			{
				return this._Answer1;
			}
			set
			{
				if ((this._Answer1 != value))
				{
					this.OnAnswer1Changing(value);
					this.SendPropertyChanging();
					this._Answer1 = value;
					this.SendPropertyChanged("Answer1");
					this.OnAnswer1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Answer2", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Answer2
		{
			get
			{
				return this._Answer2;
			}
			set
			{
				if ((this._Answer2 != value))
				{
					this.OnAnswer2Changing(value);
					this.SendPropertyChanging();
					this._Answer2 = value;
					this.SendPropertyChanged("Answer2");
					this.OnAnswer2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Answer3", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Answer3
		{
			get
			{
				return this._Answer3;
			}
			set
			{
				if ((this._Answer3 != value))
				{
					this.OnAnswer3Changing(value);
					this.SendPropertyChanging();
					this._Answer3 = value;
					this.SendPropertyChanged("Answer3");
					this.OnAnswer3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Answer4", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Answer4
		{
			get
			{
				return this._Answer4;
			}
			set
			{
				if ((this._Answer4 != value))
				{
					this.OnAnswer4Changing(value);
					this.SendPropertyChanging();
					this._Answer4 = value;
					this.SendPropertyChanged("Answer4");
					this.OnAnswer4Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoundAS1", DbType="NVarChar(100)")]
		public string SoundAS1
		{
			get
			{
				return this._SoundAS1;
			}
			set
			{
				if ((this._SoundAS1 != value))
				{
					this.OnSoundAS1Changing(value);
					this.SendPropertyChanging();
					this._SoundAS1 = value;
					this.SendPropertyChanged("SoundAS1");
					this.OnSoundAS1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoundAS2", DbType="NVarChar(100)")]
		public string SoundAS2
		{
			get
			{
				return this._SoundAS2;
			}
			set
			{
				if ((this._SoundAS2 != value))
				{
					this.OnSoundAS2Changing(value);
					this.SendPropertyChanging();
					this._SoundAS2 = value;
					this.SendPropertyChanged("SoundAS2");
					this.OnSoundAS2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoundAS3", DbType="NVarChar(100)")]
		public string SoundAS3
		{
			get
			{
				return this._SoundAS3;
			}
			set
			{
				if ((this._SoundAS3 != value))
				{
					this.OnSoundAS3Changing(value);
					this.SendPropertyChanging();
					this._SoundAS3 = value;
					this.SendPropertyChanged("SoundAS3");
					this.OnSoundAS3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoundAS4", DbType="NVarChar(100)")]
		public string SoundAS4
		{
			get
			{
				return this._SoundAS4;
			}
			set
			{
				if ((this._SoundAS4 != value))
				{
					this.OnSoundAS4Changing(value);
					this.SendPropertyChanging();
					this._SoundAS4 = value;
					this.SendPropertyChanged("SoundAS4");
					this.OnSoundAS4Changed();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute()]
	public partial class EngUnit : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _Lesson;
		
		private string _Image;
		
		private string _ImageNotC;
		
		private int _Point;
		
		private int _Completed;
		
		private string _Title;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnLessonChanging(int value);
    partial void OnLessonChanged();
    partial void OnImageChanging(string value);
    partial void OnImageChanged();
    partial void OnImageNotCChanging(string value);
    partial void OnImageNotCChanged();
    partial void OnPointChanging(int value);
    partial void OnPointChanged();
    partial void OnCompletedChanging(int value);
    partial void OnCompletedChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    #endregion
		
		public EngUnit()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lesson", DbType="Int NOT NULL")]
		public int Lesson
		{
			get
			{
				return this._Lesson;
			}
			set
			{
				if ((this._Lesson != value))
				{
					this.OnLessonChanging(value);
					this.SendPropertyChanging();
					this._Lesson = value;
					this.SendPropertyChanged("Lesson");
					this.OnLessonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this.OnImageChanging(value);
					this.SendPropertyChanging();
					this._Image = value;
					this.SendPropertyChanged("Image");
					this.OnImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageNotC", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string ImageNotC
		{
			get
			{
				return this._ImageNotC;
			}
			set
			{
				if ((this._ImageNotC != value))
				{
					this.OnImageNotCChanging(value);
					this.SendPropertyChanging();
					this._ImageNotC = value;
					this.SendPropertyChanged("ImageNotC");
					this.OnImageNotCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Point", DbType="Int NOT NULL")]
		public int Point
		{
			get
			{
				return this._Point;
			}
			set
			{
				if ((this._Point != value))
				{
					this.OnPointChanging(value);
					this.SendPropertyChanging();
					this._Point = value;
					this.SendPropertyChanged("Point");
					this.OnPointChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Completed", DbType="Int NOT NULL")]
		public int Completed
		{
			get
			{
				return this._Completed;
			}
			set
			{
				if ((this._Completed != value))
				{
					this.OnCompletedChanging(value);
					this.SendPropertyChanging();
					this._Completed = value;
					this.SendPropertyChanged("Completed");
					this.OnCompletedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
