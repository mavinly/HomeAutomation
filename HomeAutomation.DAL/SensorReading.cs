//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HomeAutomation.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class SensorReading
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SensorReading()
        {
            this.DoorSwitchSensors = new HashSet<DoorSwitchSensor>();
        }
    
        public int Id { get; set; }
        public int SensorID { get; set; }
        public System.DateTime ReadingDateTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoorSwitchSensor> DoorSwitchSensors { get; set; }
        public virtual Sensor Sensor { get; set; }
    }
}