//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client : Person
    {
        public Client()
        {
            this.Lendings = new HashSet<Lending>();
        }
    
        
    	private string _CardNumber;
    	public string CardNumber 
    	{		
    		get
    		{
    			return _CardNumber;
    		} 
    		set
    		{
    			_CardNumber = String.IsNullOrWhiteSpace(value) ? null : value.Trim();
    		}
     	}
        
    	private string _AdditionalInfo;
    	public string AdditionalInfo 
    	{		
    		get
    		{
    			return _AdditionalInfo;
    		} 
    		set
    		{
    			_AdditionalInfo = String.IsNullOrWhiteSpace(value) ? null : value.Trim();
    		}
     	}
    
        public virtual ICollection<Lending> Lendings { get; set; }
    }
}
