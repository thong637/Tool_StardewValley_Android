using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Xamarin.Forms;
namespace DTNGamer.Interface
{

    public class Manifest 
    {
           public string Name {get;set;} 
           public string Description {get;set;}
           public string ID {get;set;}
           public string Namespace {get;set;} 
           public string EntryDll {get;set;}
           public List<string> References {get;set;} = new List<string>();
           public Species Species {get;set;}
           public Dictionary<string,string> Language {get;set;} = new Dictionary<string, string>();
    }
    public class SaveFile
    {
    	public SaveCreateMod SaveCreateMod {get;set;}
    	public string Data {get;set;}
    }
    public class ListSaveFile : List<SaveFile>
    {
    	
    }
    public class SaveCreateMod
    {
    	public string Name {get;set;}
    	public string Author {get;set;}
    	public string Version {get;set;}
    	public string Description {get;set;}
    	public string UniqueID {get;set;}
    	public ContentPackFor ContentPackFor {get;set;}
    }
    
    public class ContentPackFor 
    {
    	public string UniqueID {get;set;}
    }
    public interface IDTNGamerAPI
    {
    	public Manifest Manifest {get; internal protected set;}
    	
    	View LoadView(Page page);
    	ContentPackFor Content();
    	
    	
    }
    public enum Species
    {
    	Tool,
    	CreateMod
    	
    }
}
