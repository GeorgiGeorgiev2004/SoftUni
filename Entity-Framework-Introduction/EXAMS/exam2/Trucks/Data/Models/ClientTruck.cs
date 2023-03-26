using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trucks.Data.Models;

public class ClientTruck
{
    [ForeignKey(nameof(Client))]
    [Required]
    public int ClientId { get; set; }
    public Client Client { get; set; }

    [ForeignKey(nameof(Truck))]
    [Required]
    public int TruckId { get; set; }
    public Truck Truck { get; set; }
}
