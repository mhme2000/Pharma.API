namespace Pharma.API.DTO;

public class OrderDTO
{
    public int UserId { get; set; }
    public List<OrderItemDTO> Items { get; set; }
    
}