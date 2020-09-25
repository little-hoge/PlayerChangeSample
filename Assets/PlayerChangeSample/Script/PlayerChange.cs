using UnityEngine;

public class PlayerChange : MonoBehaviour
{
    /// <summary> 画像データ群 </summary>
    [SerializeField] public Sprite[] sprites { get; private set; }
    
    /// <summary> プレイヤー画像 </summary>
    [SerializeField] public SpriteRenderer playerSprites { get; private set; }
  

    void Start()
    {
        playerSprites = GameObject.Find("Player").GetComponent<SpriteRenderer>();
        sprites = Resources.LoadAll<Sprite>("Image/");
    }

    public void OnClick_Change() {

        var index = int.Parse(playerSprites.sprite.name);
        index = (index + 1) % sprites.Length;

        playerSprites.sprite = sprites[index];
    }
    
}
